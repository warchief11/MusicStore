using MusicStore.Core;
using MusicStore.Models;
using MusicStore.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class ShoppingCartController : BaseController
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ShoppingCartViewModel viewModel = GetShoppingCartVMAsync();
            return View(viewModel);
        }

        private ShoppingCartViewModel GetShoppingCartVMAsync()
        {
            var viewModel = new ShoppingCartViewModel();
            viewModel.CartItems = _shoppingCart.GetCartItems();
            viewModel.Total = _shoppingCart.GetTotal();
            return viewModel;
        }

        public async Task<ActionResult> AddToCart(int albumID)
        {
            var album = _dbContext.Albums.FirstOrDefault(a => a.AlbumId == albumID);
            await _shoppingCart.AddCartItem(album);
            await _dbContext.SaveChangesAsync();
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }

        // GET: ShoppingCart
        public PartialViewResult CartSummary()
        {
            var viewModel = new ShoppingCartViewModel();
            viewModel.CartItems = _shoppingCart.GetCartItems();
            viewModel.Total = _shoppingCart.GetTotal();
            return PartialView("_CartSummary", viewModel);
        }

        public async Task<ActionResult> RemoveFromCart(int cartItemId)
        {
            _shoppingCart.RemoveFromCart(cartItemId);
            await _dbContext.SaveChangesAsync();
            var shoppingCartVM = GetShoppingCartVMAsync();
            return PartialView("_CartDetails", shoppingCartVM);
        }
    }
}