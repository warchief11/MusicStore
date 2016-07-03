using MusicStore.Core;
using MusicStore.DAL.Models;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicStore.Areas.Admin.Controllers
{
    public class StoreManagerController : BaseController
    {
        // GET: StoreManager
        public async Task<ActionResult> Index()
        {
            var albums = _dbContext.Query<Album>().Include(a => a.Artist).Include(a => a.Genre);
            return View(await albums.ToListAsync());
        }

        // GET: StoreManager/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = await _dbContext.Query<Album>().FirstAsync(x => x.AlbumId  == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.ArtistId = new SelectList(_dbContext.Query<Artist>(), "ArtistId", "Name");
            ViewBag.GenreId = new SelectList(_dbContext.Query<Genre>(), "GenreId", "Name");
            return View();
        }

        // POST: StoreManager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(album);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ArtistId = new SelectList(_dbContext.Query<Artist>(), "ArtistId", "Name", album.ArtistId);
            ViewBag.GenreId = new SelectList(_dbContext.Query<Genre>(), "GenreId", "Name", album.GenreId);
            return View(album);
        }

        // GET: StoreManager/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = await _dbContext.Query<Album>().FirstOrDefaultAsync(x => x.AlbumId == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            ViewBag.ArtistId = new SelectList(_dbContext.Query<Artist>(), "ArtistId", "Name", album.ArtistId);
            ViewBag.GenreId = new SelectList(_dbContext.Query<Genre>(), "GenreId", "Name", album.GenreId);
            return View(album);
        }

        // POST: StoreManager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "AlbumId,GenreId,ArtistId,Title,Price,AlbumArtUrl")] Album album)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Update<Album>(album);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ArtistId = new SelectList(_dbContext.Query<Artist>(), "ArtistId", "Name", album.ArtistId);
            ViewBag.GenreId = new SelectList(_dbContext.Query<Genre>(), "GenreId", "Name", album.GenreId);
            return View(album);
        }

        // GET: StoreManager/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = await _dbContext.Query<Album>().FirstOrDefaultAsync(x => x.AlbumId == id);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(album);
        }

        // POST: StoreManager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Album album = await _dbContext.Query<Album>().FirstOrDefaultAsync(x => x.AlbumId == id);
            _dbContext.Remove(album);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}