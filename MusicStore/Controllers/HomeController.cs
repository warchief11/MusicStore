using MusicStore.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    [RequireHttps]
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var topSellingAlbums = _dbContext.Albums.Take(10).ToList();
            return View(topSellingAlbums);
        }
    }
}