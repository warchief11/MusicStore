using MusicStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicStore.Tests.MockData
{


    class MusicStoreTestData
    {
        public static IQueryable<Album> Albums
        {
            get
            {
                return GetAlbums(GetGenres(), GetArtists()).AsQueryable();
            }
        }

        public static IQueryable<Genre> Genres
        {
            get
            {
                return GetGenres().AsQueryable();
            }
        }
        public static IQueryable<Artist> Artists
        {
            get
            {
                return GetArtists().AsQueryable();
            }
        }

        private static readonly Random random = new Random();

        private static string AlbumImg()
        {
            return string.Format("/Content/Images/AlbumArt/CD{0}.png", random.Next(1, 20));
        }

        private static decimal Price()
        {
            return (decimal)random.Next(6, 12) + 0.99M;
        }

        private static List<Album> GetAlbums(List<Genre> genres, List<Artist> artists)
        {
            var albums = new List<Album>();

            albums.Add(new Album { Title = "...And Justice For All", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "10,000 Days", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Tool"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "11i", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Supreme Beings of Leisure"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "1960", Genre = genres.Single(g => g.Name == "Indie"), Price = Price(), Artist = artists.Single(a => a.Name == "Soul-Junk"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "4x4=12 ", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "deadmau5"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "A Lively Mind", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Paul Oakenfold"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "A Rush of Blood to the Head", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Coldplay"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "A Winter Symphony", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Abbey Road", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Beatles"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Achtung Baby", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "U2"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Adrenaline", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Deftones"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Ænima", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Tool"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "After the Goldrush", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Neil Young"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Airdrawn Dagger", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Sasha"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Album Title Goes Here", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "deadmau5"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Alive 2007", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Daft Punk"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "All I Ask of You", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Amen (So Be It)", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Paddy Casey"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Animal Vehicle", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "The Axis of Awesome"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Apocalyptic Love", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Slash"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Automatic for the People", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "R.E.M."), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Babel", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Mumford & Sons"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Bad Motorfinger", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Soundgarden"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Banadeek Ta'ala", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Amr Diab"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Barbie Girl", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Aqua"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Be Here Now", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Oasis"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Bedrock 11 Compiled & Mixed", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "John Digweed"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Big Bad Wolf ", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Armand Van Helden"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Black", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Blackwater Park", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Opeth"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Blood", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "In This Moment"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Blue", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Weezer"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Boys & Girls", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Alabama Shakes"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Bunkka", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Paul Oakenfold"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Chocolate Starfish And The Hot Dog Flavored Water", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Limp Bizkit"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Ciao, Baby", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "TheStart"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Classic Munkle: Turbo Edition", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Munkle"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Classics: The Best of Sarah Brightman", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Come Away With Me", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "Norah Jones"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Comfort Eagle", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Cake"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Common Reaction", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Uh Huh Her "), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Core", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Stone Temple Pilots"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Cornerstone", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Styx"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Cosmicolor", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "M-Flo"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Cross", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Justice"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Culture of Fear", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Thievery Corporation"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Dakshina", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Deva Premal"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Dark Side of the Moon", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Pink Floyd"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Death Magnetic", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Deep End of Down", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Above the Fold"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Deja Vu", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Crosby, Stills, Nash, and Young"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Di Korpu Ku Alma", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Lura"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Diary of a Madman", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Ozzy Osbourne"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Dirt", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Alice in Chains"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Drum'n'bass for Papa", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Plug"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Duluth", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Trampled By Turtles"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Dummy", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Portishead"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Earl Scruggs and Friends", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Earl Scruggs"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Eden", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "El Camino", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Black Keys"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Elegant Gypsy", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "Al di Meola"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Elements Of Life", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Tiësto"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Emotion", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Papa Wemba"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Facelift", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Alice in Chains"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Fair Warning", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Van Halen"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Fear of a Black Planet", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Public Enemy"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Feels Like Home", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "Norah Jones"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Fly", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Four", Genre = genres.Single(g => g.Name == "Blues"), Price = Price(), Artist = artists.Single(a => a.Name == "Blues Traveler"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Further Down the Spiral", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Nine Inch Nails"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Garbage", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Garbage"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Good News For People Who Love Bad News", Genre = genres.Single(g => g.Name == "Indie"), Price = Price(), Artist = artists.Single(a => a.Name == "Modest Mouse"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Gordon", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Barenaked Ladies"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Greatest Hits", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Duck Sauce"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Group Therapy", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Above & Beyond"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Greetings from Michigan", Genre = genres.Single(g => g.Name == "Indie"), Price = Price(), Artist = artists.Single(a => a.Name == "Sufjan Stevens"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Heart On", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Eagles of Death Metal"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Holy Diver", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Dio"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Homework", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Daft Punk"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Houses Of The Holy", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Human", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Projected"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Hunky Dory", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "David Bowie"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Hymns", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Projected"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Hysteria", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Def Leppard"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "In Absentia", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Porcupine Tree"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "In Between", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Paul Van Dyk"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "In Rainbows", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Radiohead"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "In the court of the Crimson King", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "King Crimson"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Indestructible", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Rancid"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Infinity", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Journey"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Introspective", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Pet Shop Boys"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "ISAM", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Amon Tobin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Jagged Little Pill", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Alanis Morissette"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Kick", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "INXS"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Kill 'Em All", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Kind of Blue", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "Miles Davis"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Kiss", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Carly Rae Jepsen"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Last Call", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Cayouche"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Le Tigre", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Le Tigre"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Led Zeppelin II", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Little Earthquakes", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Tori Amos"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Live on Earth", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "The Cat Empire"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Living", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Paddy Casey"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Love Changes Everything", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Magical Mystery Tour", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "The Beatles"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Marasim", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Jagjit Singh"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Master of Puppets", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Mechanics & Mathematics", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Venus Hum"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Mental Jewelry", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Live"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Metallics", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "meteora", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Linkin Park"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Mezzanine", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Massive Attack"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Moving Pictures", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Rush"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Murder Ballads", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Nick Cave and the Bad Seeds"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Music For The Jilted Generation", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "The Prodigy"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "My Name is Skrillex", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Skrillex"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Nevermind", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Nirvana"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "New Divide", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Linkin Park"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "New York Dolls", Genre = genres.Single(g => g.Name == "Punk"), Price = Price(), Artist = artists.Single(a => a.Name == "New York Dolls"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Night At The Opera", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Queen"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Night Castle", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Trans-Siberian Orchestra"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Nkolo", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Lokua Kanza"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "O Brother, Where Art Thou?", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Alison Krauss"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "O(+>", Genre = genres.Single(g => g.Name == "R&B"), Price = Price(), Artist = artists.Single(a => a.Name == "Prince"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Oceania", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Smashing Pumpkins"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Off the Deep End", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Weird Al"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "OK Computer", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Radiohead"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "One Love", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "David Guetta"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Operation: Mindcrime", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Queensrÿche"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Opiate", Genre = genres.Single(g => g.Name == "Rock"), Price = 8.99M, Artist = artists.Single(a => a.Name == "Tool"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Paid in Full", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Eric B. and Rakim"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Para Siempre", Genre = genres.Single(g => g.Name == "Latin"), Price = Price(), Artist = artists.Single(a => a.Name == "Vicente Fernandez"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Pause", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Four Tet"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Peace Sells... but Who's Buying", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Megadeth"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Physical Graffiti", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Pinkerton", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Weezer"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Pretty Hate Machine", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Nine Inch Nails"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Prisoner", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Jezabels"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Privateering", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Mark Knopfler"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "PSY's Best 6th Part 1", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "PSY"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Purple", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Stone Temple Pilots"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Raices", Genre = genres.Single(g => g.Name == "Latin"), Price = Price(), Artist = artists.Single(a => a.Name == "Los Tigres del Norte"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Raising Hell", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Run DMC"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Raoul and the Kings of Spain ", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Tears For Fears"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Recovery [Explicit]", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Eminem"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Reign In Blood", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Slayer"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Relayed", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Yes"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Revolver", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Beatles"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Ride the Lighting ", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Metallica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Rise of the Phoenix", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Before the Dawn"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Room for Squares", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "John Mayer"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Root Down", Genre = genres.Single(g => g.Name == "Jazz"), Price = Price(), Artist = artists.Single(a => a.Name == "Jimmy Smith"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Rounds", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Four Tet"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Rubber Factory", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Black Keys"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Rust in Peace", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Megadeth"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Saturday Night Fever", Genre = genres.Single(g => g.Name == "R&B"), Price = Price(), Artist = artists.Single(a => a.Name == "Bee Gees"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Scary Monsters and Nice Sprites", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Skrillex"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Second Coming", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Stone Roses"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Serious About Men", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "The Rubberbandits"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Short Bus", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Filter"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Singles Collection", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "David Bowie"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Six Degrees of Inner Turbulence", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Dream Theater"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Slave To The Empire", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "T&N"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Slouching Towards Bethlehem", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Robert James"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Smash", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Offspring"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Something Special", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Dolly Parton"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Song(s) You Know By Heart", Genre = genres.Single(g => g.Name == "Country"), Price = Price(), Artist = artists.Single(a => a.Name == "Jimmy Buffett"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Sound of Music", Genre = genres.Single(g => g.Name == "Punk"), Price = Price(), Artist = artists.Single(a => a.Name == "Adicts"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Spiritual State", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Nujabes"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Still Life", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Opeth"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Stop Making Sense", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Talking Heads"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Stranger than Fiction", Genre = genres.Single(g => g.Name == "Punk"), Price = Price(), Artist = artists.Single(a => a.Name == "Bad Religion"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Supermodified", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Amon Tobin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Switched-On Bach", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Wendy Carlos"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Symphony", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Ted Nugent", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Ted Nugent"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Teflon Don", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Rick Ross"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Tell Another Joke at the Ol' Choppin' Block", Genre = genres.Single(g => g.Name == "Indie"), Price = Price(), Artist = artists.Single(a => a.Name == "Danielson Famile"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Ten", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Pearl Jam"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Texas Flood", Genre = genres.Single(g => g.Name == "Blues"), Price = Price(), Artist = artists.Single(a => a.Name == "Stevie Ray Vaughan"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Best of 1990–2000", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Bridge", Genre = genres.Single(g => g.Name == "R&B"), Price = Price(), Artist = artists.Single(a => a.Name == "Melanie Fiona"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Cage", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Tygers of Pan Tang"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Chicago Transit Authority", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Chicago "), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Chronic", Genre = genres.Single(g => g.Name == "Rap"), Price = Price(), Artist = artists.Single(a => a.Name == "Dr. Dre"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Crane Wife", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "The Decemberists"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Cure", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "The Cure"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Dark Side Of The Moon", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Pink Floyd"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Divine Conspiracy", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Epica"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Dream of the Blue Turtles", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Sting"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Final Frontier", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Iron Maiden"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Head and the Heart", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Head and the Heart"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Joshua Tree", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "U2"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Lumineers", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Lumineers"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Southern Harmony and Musical Companion", Genre = genres.Single(g => g.Name == "Blues"), Price = Price(), Artist = artists.Single(a => a.Name == "The Black Crowes"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Spade", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Butch Walker & The Black Widows"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Stone Roses", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Stone Roses"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Suburbs", Genre = genres.Single(g => g.Name == "Indie"), Price = Price(), Artist = artists.Single(a => a.Name == "Arcade Fire"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Three Tenors Disc1/Disc2", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Carreras, Pavarotti, Domingo"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Trees They Grow So High", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "The Wall", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Pink Floyd"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Them Crooked Vultures", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Them Crooked Vultures"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "This Is Happening", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "LCD Soundsystem"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Thunder, Lightning, Strike", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Go! Team"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Time to Say Goodbye", Genre = genres.Single(g => g.Name == "Classical"), Price = Price(), Artist = artists.Single(a => a.Name == "Sarah Brightman"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Time, Love & Tenderness", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "Michael Bolton"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Tomorrow Starts Today", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Mobile"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Tuesday Night Music Club", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Sheryl Crow"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Umoja", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "BLØF"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Under the Pink", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Tori Amos"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Undertow", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Tool"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Untrue", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Burial"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Use Your Illusion I", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Use Your Illusion II", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Guns N' Roses"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Version 2.0", Genre = genres.Single(g => g.Name == "Alternative"), Price = Price(), Artist = artists.Single(a => a.Name == "Garbage"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Wapi Yo", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Lokua Kanza"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Wasteland Discotheque", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Raunchy"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Watermark", Genre = genres.Single(g => g.Name == "Electronic"), Price = Price(), Artist = artists.Single(a => a.Name == "Enya"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "We Were Exploding Anyway", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "65daysofstatic"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "White Pony", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Deftones"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Who's Next", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "The Who"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Wish You Were Here", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Pink Floyd"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "With Oden on Our Side", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Amon Amarth"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Worship Music", Genre = genres.Single(g => g.Name == "Metal"), Price = Price(), Artist = artists.Single(a => a.Name == "Anthrax"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "X&Y", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Coldplay"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Xinti", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "Sara Tavares"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Yano", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Yano"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Yesterday Once More Disc 1/Disc 2", Genre = genres.Single(g => g.Name == "Pop"), Price = Price(), Artist = artists.Single(a => a.Name == "The Carpenters"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "Zoso", Genre = genres.Single(g => g.Name == "Rock"), Price = Price(), Artist = artists.Single(a => a.Name == "Led Zeppelin"), AlbumArtUrl = AlbumImg() });
            albums.Add(new Album { Title = "עד גבול האור", Genre = genres.Single(g => g.Name == "World"), Price = Price(), Artist = artists.Single(a => a.Name == "אריק אינשטיין"), AlbumArtUrl = AlbumImg() });
            return albums;
        }

        private static List<Artist> GetArtists()
        {
            var artists = new List<Artist>
            {
                new Artist { Name = "65daysofstatic" },
                new Artist { Name = "Above & Beyond" },
                new Artist { Name = "Above the Fold" },
                new Artist { Name = "Adicts" },
                new Artist { Name = "Al di Meola" },
                new Artist { Name = "Alabama Shakes" },
                new Artist { Name = "Alanis Morissette" },
                new Artist { Name = "Alice in Chains" },
                new Artist { Name = "Alison Krauss" },
                new Artist { Name = "Amon Amarth" },
                new Artist { Name = "Amon Tobin" },
                new Artist { Name = "Amr Diab" },
                new Artist { Name = "Anthrax" },
                new Artist { Name = "Aqua" },
                new Artist { Name = "Armand Van Helden" },
                new Artist { Name = "Arcade Fire" },
                new Artist { Name = "Bad Religion" },
                new Artist { Name = "Barenaked Ladies" },
                new Artist { Name = "Bee Gees" },
                new Artist { Name = "Before the Dawn" },
                new Artist { Name = "BLØF" },
                new Artist { Name = "Blues Traveler" },
                new Artist { Name = "Burial" },
                new Artist { Name = "Butch Walker & The Black Widows" },
                new Artist { Name = "Cake" },
                new Artist { Name = "Carly Rae Jepsen" },
                new Artist { Name = "Carreras, Pavarotti, Domingo" },
                new Artist { Name = "Cayouche" },
                new Artist { Name = "Chicago " },
                new Artist { Name = "Chicago Symphony Orchestra & Fritz Reiner" },
                new Artist { Name = "Coldplay" },
                new Artist { Name = "Crosby, Stills, Nash, and Young" },
                new Artist { Name = "Daft Punk" },
                new Artist { Name = "Danielson Famile" },
                new Artist { Name = "David Bowie" },
                new Artist { Name = "David Guetta" },
                new Artist { Name = "deadmau5" },
                new Artist { Name = "Deep Purple" },
                new Artist { Name = "Def Leppard" },
                new Artist { Name = "Deftones" },
                new Artist { Name = "Deva Premal" },
                new Artist { Name = "Dio" },
                new Artist { Name = "Dolly Parton" },
                new Artist { Name = "Dr. Dre" },
                new Artist { Name = "Dream Theater" },
                new Artist { Name = "Duck Sauce" },
                new Artist { Name = "Earl Scruggs" },
                new Artist { Name = "Elis Regina" },
                new Artist { Name = "Eminem" },
                new Artist { Name = "Enya" },
                new Artist { Name = "Epica" },
                new Artist { Name = "Eric B. and Rakim" },
                new Artist { Name = "Filter" },
                new Artist { Name = "Four Tet" },
                new Artist { Name = "Garbage" },
                new Artist { Name = "Guns N' Roses" },
                new Artist { Name = "In This Moment" },
                new Artist { Name = "INXS" },
                new Artist { Name = "Iron Maiden" },
                new Artist { Name = "Jagjit Singh" },
                new Artist { Name = "Jimmy Buffett" },
                new Artist { Name = "Jimmy Smith" },
                new Artist { Name = "John Digweed" },
                new Artist { Name = "John Mayer" },
                new Artist { Name = "Jota Quest" },
                new Artist { Name = "Journey" },
                new Artist { Name = "Justice" },
                new Artist { Name = "King Crimson" },
                new Artist { Name = "Kiss" },
                new Artist { Name = "LCD Soundsystem" },
                new Artist { Name = "Le Tigre" },
                new Artist { Name = "Led Zeppelin" },
                new Artist { Name = "Limp Bizkit" },
                new Artist { Name = "Linkin Park" },
                new Artist { Name = "Live" },
                new Artist { Name = "Lokua Kanza" },
                new Artist { Name = "Los Tigres del Norte" },
                new Artist { Name = "Lura" },
                new Artist { Name = "Mark Knopfler" },
                new Artist { Name = "Massive Attack" },
                new Artist { Name = "Megadeth" },
                new Artist { Name = "Melanie Fiona" },
                new Artist { Name = "Metallica" },
                new Artist { Name = "M-Flo" },
                new Artist { Name = "Michael Bolton" },
                new Artist { Name = "Miles Davis" },
                new Artist { Name = "Mobile" },
                new Artist { Name = "Modest Mouse" },
                new Artist { Name = "Mumford & Sons" },
                new Artist { Name = "Munkle" },
                new Artist { Name = "Neil Young" },
                new Artist { Name = "New York Dolls" },
                new Artist { Name = "Nick Cave and the Bad Seeds" },
                new Artist { Name = "Nine Inch Nails" },
                new Artist { Name = "Nirvana" },
                new Artist { Name = "Norah Jones" },
                new Artist { Name = "Nujabes" },
                new Artist { Name = "Oasis" },
                new Artist { Name = "Opeth" },
                new Artist { Name = "Ozzy Osbourne" },
                new Artist { Name = "Paddy Casey" },
                new Artist { Name = "Papa Wemba" },
                new Artist { Name = "Paul Oakenfold" },
                new Artist { Name = "Paul Van Dyk" },
                new Artist { Name = "Pearl Jam" },
                new Artist { Name = "Pet Shop Boys" },
                new Artist { Name = "Pink Floyd" },
                new Artist { Name = "Plug" },
                new Artist { Name = "Porcupine Tree" },
                new Artist { Name = "Portishead" },
                new Artist { Name = "Prince" },
                new Artist { Name = "Projected" },
                new Artist { Name = "PSY" },
                new Artist { Name = "Public Enemy" },
                new Artist { Name = "Queen" },
                new Artist { Name = "Queensrÿche" },
                new Artist { Name = "R.E.M." },
                new Artist { Name = "Radiohead" },
                new Artist { Name = "Rancid" },
                new Artist { Name = "Raunchy" },
                new Artist { Name = "Rick Ross" },
                new Artist { Name = "Robert James" },
                new Artist { Name = "Run DMC" },
                new Artist { Name = "Rush" },
                new Artist { Name = "Sara Tavares" },
                new Artist { Name = "Sarah Brightman" },
                new Artist { Name = "Sasha" },
                new Artist { Name = "Sheryl Crow" },
                new Artist { Name = "Skrillex" },
                new Artist { Name = "Slash" },
                new Artist { Name = "Slayer" },
                new Artist { Name = "Soul-Junk" },
                new Artist { Name = "Soundgarden" },
                new Artist { Name = "Stevie Ray Vaughan" },
                new Artist { Name = "Sting" },
                new Artist { Name = "Stone Temple Pilots" },
                new Artist { Name = "Styx" },
                new Artist { Name = "Sufjan Stevens" },
                new Artist { Name = "Supreme Beings of Leisure" },
                new Artist { Name = "System Of A Down" },
                new Artist { Name = "T&N" },
                new Artist { Name = "Talking Heads" },
                new Artist { Name = "Tears For Fears" },
                new Artist { Name = "Ted Nugent" },
                new Artist { Name = "Temple of the Dog" },
                new Artist { Name = "The Axis of Awesome" },
                new Artist { Name = "The Beatles" },
                new Artist { Name = "The Black Crowes" },
                new Artist { Name = "The Black Keys" },
                new Artist { Name = "The Carpenters" },
                new Artist { Name = "The Cat Empire" },
                new Artist { Name = "The Cure" },
                new Artist { Name = "The Decemberists" },
                new Artist { Name = "The Eagles of Death Metal" },
                new Artist { Name = "The Go! Team" },
                new Artist { Name = "The Head and the Heart" },
                new Artist { Name = "The Jezabels" },
                new Artist { Name = "The Lumineers" },
                new Artist { Name = "The Offspring" },
                new Artist { Name = "The Prodigy" },
                new Artist { Name = "The Rubberbandits" },
                new Artist { Name = "The Smashing Pumpkins" },
                new Artist { Name = "The Stone Roses" },
                new Artist { Name = "The Who" },
                new Artist { Name = "Them Crooked Vultures" },
                new Artist { Name = "TheStart" },
                new Artist { Name = "Thievery Corporation" },
                new Artist { Name = "Tiësto" },
                new Artist { Name = "Tool" },
                new Artist { Name = "Tori Amos" },
                new Artist { Name = "Trampled By Turtles" },
                new Artist { Name = "Trans-Siberian Orchestra" },
                new Artist { Name = "Tygers of Pan Tang" },
                new Artist { Name = "U2" },
                new Artist { Name = "Uh Huh Her " },
                new Artist { Name = "Van Halen" },
                new Artist { Name = "Venus Hum" },
                new Artist { Name = "Vicente Fernandez" },
                new Artist { Name = "Weezer" },
                new Artist { Name = "Weird Al" },
                new Artist { Name = "Wendy Carlos" },
                new Artist { Name = "Yano" },
                new Artist { Name = "Yes" },
                new Artist { Name = "אריק אינשטיין"}
            };
            return artists;
        }

        private static List<Genre> GetGenres()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Pop" },
                new Genre { Name = "Rock" },
                new Genre { Name = "Jazz" },
                new Genre { Name = "Metal" },
                new Genre { Name = "Electronic" },
                new Genre { Name = "Blues" },
                new Genre { Name = "Latin" },
                new Genre { Name = "Rap" },
                new Genre { Name = "Classical" },
                new Genre { Name = "Alternative" },
                new Genre { Name = "Country" },
                new Genre { Name = "R&B" },
                new Genre { Name = "Indie" },
                new Genre { Name = "Punk" },
                new Genre { Name = "World" }
            };
            return genres;
        }

    }
}
