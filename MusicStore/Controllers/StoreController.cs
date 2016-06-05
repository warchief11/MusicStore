using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        private MusicStoreContext _musicStoreContext;

        public StoreController()
        {
            _musicStoreContext = new MusicStoreContext();
        }

        // GET: Store
        public ActionResult Index()
        {
           
            var genreList = _musicStoreContext.Genres.ToList();
            return View(genreList);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = _musicStoreContext.Genres.Where(g => string.Compare(g.Name, genre, false) == 0).Include(g => g.Albums).FirstOrDefault();
            genreModel = _musicStoreContext.Genres.Include(g => g.Albums).FirstOrDefault(g => string.Compare(g.Name, genre, false) == 0);
            return View(genreModel);
        }

        public ActionResult Details(int albumId)
        {

            var album = _musicStoreContext.Albums.FirstOrDefault(a => a.AlbumId == albumId);
            return View(album);
        }
    }
}