﻿using MusicStore.Core;
using MusicStore.DAL.Models;
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
                _dbContext.Add(order);

                await ShoppingCart.CreateOrder(order);

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
            var order = _dbContext.Query<Order>().Include(o => o.OrderDetails).FirstOrDefault();
            if (order == null)
            {
                return View("Error");
            }
            return View(order);
        }
    }
}