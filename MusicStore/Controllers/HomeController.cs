using MusicStore.Core;
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
        public async Task<ActionResult> Index()
        {
            var viewModel = new HomePageViewModel();
            viewModel.TopSellingAlbums = _dbContext.Albums.Take(10).ToList();
            viewModel.FeaturedArtist = await _dbContext.Artists.FirstOrDefaultAsync(a => a.Name == "The Beatles");
            viewModel.FeaturedAlbums = await _dbContext.Albums.Where(a => a.ArtistId == viewModel.FeaturedArtist.ArtistId).Take(8).ToListAsync();

            return View(viewModel);
        }
    }
}