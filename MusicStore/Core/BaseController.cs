using MusicStore.DAL.Models;
using System;
using System.Web.Mvc;

namespace MusicStore.Core
{
    public class BaseController : Controller
    {
        protected MusicStoreContext _dbContext;
        protected ShoppingCart _shoppingCart;

        public BaseController()
        {
            _dbContext = new MusicStoreContext();
            _shoppingCart = ShoppingCart.GetCart(_dbContext, GetCartID());
        }

        private string GetCartID()
        {
            string _shoppingCartID = System.Web.HttpContext.Current.Session["ShoppingCartID"] as string;
            if (_shoppingCartID == null)
            {
                _shoppingCartID = Guid.NewGuid().ToString();
                System.Web.HttpContext.Current.Session["ShoppingCartID"] = _shoppingCartID;
            }
            return _shoppingCartID;
        }

        public ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToHome();
        }

        public ActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}