using MusicStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.ViewModels
{
    public class HomePageViewModel
    {
        public Artist FeaturedArtist { get; set; }
        public List<Album> FeaturedAlbums { get; set; }
        public List<Album> TopSellingAlbums { get; set; }
    }
}