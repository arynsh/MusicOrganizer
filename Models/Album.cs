using System;

namespace Music
{
    public class Album
    {
        public string Name {get; set; }
        public int Year {get; set; }

        public Album(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}