using MusicStore.Core;
using MusicStore.DAL;
using MusicStore.DAL.Models;
using MusicStore.ViewModels;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    [RequireHttps]
    public class HomeController : BaseController
    {
        public HomeController() : base()
        {
        }

        public HomeController(IMusicStoreContext dbContext) : base(dbContext)
        {
        }

        public async Task<ActionResult> Index()
        {
            var viewModel = new HomePageViewModel();
            viewModel.TopSellingAlbums = _dbContext.Query<Album>().Take(10).ToList();
            viewModel.FeaturedArtist = await _dbContext.Query<Artist>().FirstOrDefaultAsync(a => a.Name == "The Beatles");
            viewModel.FeaturedAlbums = await _dbContext.Query<Album>().Where(a => a.ArtistId == viewModel.FeaturedArtist.ArtistId).Take(8).ToListAsync();

            return View(viewModel);
        }
    }
}