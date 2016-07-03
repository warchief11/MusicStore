using MusicStore.DAL.Models;
using System.Collections.Generic;

namespace MusicStore.ViewModels
{
    public class HomePageViewModel
    {
        public Artist FeaturedArtist { get; set; }
        public List<Album> FeaturedAlbums { get; set; }
        public List<Album> TopSellingAlbums { get; set; }
    }
}