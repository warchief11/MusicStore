using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }

        public string ImageUrl { get; set; }

        public string Singer { get; set; }

    }
}