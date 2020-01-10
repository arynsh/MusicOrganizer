// 1. homepage for individual artist, display all info 3. create new artist 4. all new album

using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Music 
{
    public class ArtistController : Controller
    {
        [HttpGet("/artist")]
        public ActionResult Index()
        {
            System.Console.WriteLine("This is artist homepage.");
            return View();
        }

        [HttpGet("/artist/{artistName}")]
        public ActionResult Show(string artistName)
        {
            //normally instantiating a new artist happens in in a HTTPPost route, only done this way because we're using a test artist. Normally we will have written the methods and methods return a value.
            List<Album> albumList = new List<Album> ();
            Album newAlbumObject = new Album("abbey road", 1968);
            albumList.Add(newAlbumObject);
            Artist artist = new Artist(artistName, albumList, 
            "classicRock");
            return View(artist);
        }
    }
}
