using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genreList = new List<Genre>
                                {
                                    new Genre { Name = "Rock" },
                                    new Genre { Name = "Disco" },
                                    new Genre { Name = "Jazz" }
                                };
            return View(genreList);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre {Name = genre };
            return View(genreModel);
        }

        public ActionResult Details(string title)
        {
            var album = new Album { Title = title };
            return View(album);
        }
    }
}