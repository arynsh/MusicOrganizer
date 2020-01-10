using System;
using System.Collections.Generic;

namespace Music
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Album> Albums { get; set; }
        public string Genre { get; set; }

        public Artist(string name, List<Album> albums, string genre)
        {
            this.Name = name;
            this.Albums = albums;
            this.Genre = genre;
        }


    }
}