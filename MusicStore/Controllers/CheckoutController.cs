using MusicStore.Core;
using MusicStore.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    [Authorize]
    [RequireHttps]
    public class CheckoutController : BaseController
    {
        //
        // GET: /Checkout/
        public ActionResult AddressAndPayment()
        {
            var order = new Order();
            return View(order);
        }

        //
        // POST: /Checkout/AddressAndPayment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddressAndPayment(Order order, CancellationToken requestAborted)
        {
            order.ShippingAddress.UserId = HttpContext.User.Identity.Name;
            order.Username = HttpContext.User.Identity.Name;
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            try
            {
                order.OrderDate = DateTime.Now;

                //Add the Order
                _dbContext.Orders.Add(order);

                await _shoppingCart.CreateOrder(order);

                // Save all changes
                await _dbContext.SaveChangesAsync(requestAborted);

                return RedirectToAction("Complete", new { id = order.OrderId });
            }
            catch
            {
                //Invalid - redisplay with errors
                return View(order);
            }
        }

        public ActionResult Complete(int orderId)
        {
            var order = _dbContext.Orders.Include(o => o.OrderDetails).FirstOrDefault();
            if (order == null)
            {
                return View("Error");
            }
            return View(order);
        }
    }
}