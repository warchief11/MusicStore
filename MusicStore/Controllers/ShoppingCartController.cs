using MusicStore.Models;
using MusicStore.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private MusicStoreContext _dbContext;
        private ShoppingCart _shoppingCart;

        public ShoppingCartController()
        {
            
            _dbContext = new MusicStoreContext();
            _shoppingCart = ShoppingCart.GetCart(_dbContext, GetCartID());
        }

        private string GetCartID()
        {
            string _shoppingCartID = System.Web.HttpContext.Current.Session["ShoppingCartID"] as string;
            if(_shoppingCartID == null)
            {
                _shoppingCartID = Guid.NewGuid().ToString();
                System.Web.HttpContext.Current.Session["ShoppingCartID"] = _shoppingCartID;
            }
            return _shoppingCartID;
        }
        // GET: ShoppingCart
        public async Task<ActionResult> Index()
        {
            var viewModel = new ShoppingCartViewModel();
            viewModel.CartItems = await _shoppingCart.GetCartItems();
            viewModel.Total = await _shoppingCart.GetTotal();
            return View(viewModel);
        }

        public async Task<ActionResult> AddToCart(int albumID)
        {
           var album = _dbContext.Albums.FirstOrDefault(a => a.AlbumId == albumID);
            await _shoppingCart.AddCartItem(album);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        //public async Task<ActionResult> AddToCart([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        //{
        //    await _shoppingCart.AddCartItem(album);
        //    await _dbContext.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        public async Task<ActionResult> RemoveFromCart(int cartItemId)
        {
            _shoppingCart.RemoveFromCart(cartItemId);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}