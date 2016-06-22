using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.DAL.Models
{
    public class ShoppingCart
    {
        private readonly IMusicStoreContext _dbContext;
        private readonly string _shoppingCartId;

        private ShoppingCart(IMusicStoreContext dbContext, string id)
        {
            _dbContext = dbContext;
            _shoppingCartId = id;
        }

        public static ShoppingCart GetCart(IMusicStoreContext dbContext, string shoppingCartId)
        {
            return new ShoppingCart(dbContext, shoppingCartId);
        }

        public async Task AddCartItem(Album album)
        {
            var cartItem = await _dbContext.Query<CartItem>().FirstOrDefaultAsync(c => c.AlbumId == album.AlbumId
                                                     && c.CartId == _shoppingCartId);

            if (cartItem == null)
            {
                //create a new one.
                cartItem = new CartItem
                {
                    CartId = _shoppingCartId,
                    AlbumId = album.AlbumId,
                    Album = album,
                    DateCreated = DateTime.Today
                };
                _dbContext.Add(cartItem);
            }
            cartItem.Count++;
        }

        public int RemoveFromCart(int id)
        {
            // Get the cart
            var cartItem = _dbContext.Query<CartItem>().SingleOrDefault(
                cart => cart.CartId == _shoppingCartId
                && cart.CartItemId == id);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    _dbContext.Remove(cartItem);
                }
            }

            return itemCount;
        }

        public async Task EmptyCart()
        {
            var cartItems = await _dbContext.Query<CartItem>()
                .Where(cart => cart.CartId == _shoppingCartId)
                .ToArrayAsync();

            _dbContext.RemoveRange(cartItems);
        }

        public List<CartItem> GetCartItems()
        {
            return _dbContext.Query<CartItem>().
                Where(cart => cart.CartId == _shoppingCartId).
                Include(c => c.Album).
                ToList();
        }

        public Task<int> GetCount()
        {
            // Get the count of each item in the cart and sum them up
            return _dbContext
                .Query<CartItem>()
                .Where(c => c.CartId == _shoppingCartId)
                .Select(c => c.Count)
                .SumAsync();
        }

        public decimal GetTotal()
        {
            // Multiply album price by count of that album to get
            // the current price for each of those albums in the cart
            // sum all album price totals to get the cart total
            var items = _dbContext.Query<CartItem>()
                                        .Include(c => c.Album)
                                        .Where(c => c.CartId == _shoppingCartId)
                                        .Select(c => c.Count * c.Album.Price)
                                        .ToList();
            if (items.Count > 0)
            {
                return items.Sum();
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> CreateOrder(Order order)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();

            // Iterate over the items in the cart, adding the order details for each
            foreach (var item in cartItems)
            {
                //var album = _db.Albums.Find(item.AlbumId);
                var album = await _dbContext.Query<Album>().SingleAsync(a => a.AlbumId == item.AlbumId);

                var orderDetail = new OrderDetail
                {
                    AlbumId = item.AlbumId,
                    OrderId = order.OrderId,
                    UnitPrice = album.Price,
                    Quantity = item.Count,
                };

                // Set the order total of the shopping cart
                orderTotal += (item.Count * album.Price);

                _dbContext.Add(orderDetail);
            }

            // Set the order's total to the orderTotal count
            order.Total = orderTotal;

            // Empty the shopping cart
            await EmptyCart();

            // Return the OrderId as the confirmation number
            return order.OrderId;
        }
    }
}