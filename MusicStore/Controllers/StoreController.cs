using MusicStore.Core;
using MusicStore.DAL.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class StoreController : BaseController
    {
        public PartialViewResult GenreList()
        {
            var genreList = _dbContext.Query<Genre>().ToList();
            return PartialView("_GenreList", genreList);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = _dbContext.Query<Genre>().Where(g => string.Compare(g.Name, genre, false) == 0).Include(g => g.Albums).FirstOrDefault();
            genreModel = _dbContext.Query<Genre>().Include(g => g.Albums).FirstOrDefault(g => string.Compare(g.Name, genre, false) == 0);
            return View(genreModel);
        }

        public ActionResult Details(int albumId)
        {
            var album = _dbContext.Query<Album>().FirstOrDefault(a => a.AlbumId == albumId);
            return View(album);
        }
    }
}