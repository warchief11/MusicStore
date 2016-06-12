using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MusicStore.Core;

namespace MusicStore.Controllers
{
    public class StoreController : BaseController
    {
        public PartialViewResult GenreList()
        {
            var genreList = _dbContext.Genres.ToList();
            return PartialView("_GenreList", genreList);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = _dbContext.Genres.Where(g => string.Compare(g.Name, genre, false) == 0).Include(g => g.Albums).FirstOrDefault();
            genreModel = _dbContext.Genres.Include(g => g.Albums).FirstOrDefault(g => string.Compare(g.Name, genre, false) == 0);
            return View(genreModel);
        }

        public ActionResult Details(int albumId)
        {

            var album = _dbContext.Albums.FirstOrDefault(a => a.AlbumId == albumId);
            return View(album);
        }
    }
}