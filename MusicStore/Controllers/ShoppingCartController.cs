using MusicStore.Core;
using MusicStore.DAL.Models;
using MusicStore.ViewModels;
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
            viewModel.CartItems = ShoppingCart.GetCartItems();
            viewModel.Total = ShoppingCart.GetTotal();
            return viewModel;
        }

        public async Task<ActionResult> AddToCart(int albumID)
        {
            var album = _dbContext.Query<Album>().FirstOrDefault(a => a.AlbumId == albumID);
            await ShoppingCart.AddCartItem(album);
            await _dbContext.SaveChangesAsync();
            return Redirect(Request.UrlReferrer.PathAndQuery);
        }

        // GET: ShoppingCart
        public PartialViewResult CartSummary()
        {
            var viewModel = new ShoppingCartViewModel();
            viewModel.CartItems = ShoppingCart.GetCartItems();
            viewModel.Total = ShoppingCart.GetTotal();
            return PartialView("_CartSummary", viewModel);
        }

        public async Task<ActionResult> RemoveFromCart(int cartItemId)
        {
            ShoppingCart.RemoveFromCart(cartItemId);
            await _dbContext.SaveChangesAsync();
            var shoppingCartVM = GetShoppingCartVMAsync();
            return PartialView("_CartDetails", shoppingCartVM);
        }
    }
}