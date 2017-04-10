using MVCMusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities db = new MusicStoreEntities();

        public ActionResult Index()
        {
            var genres = db.Genres.ToList();
            return View(genres);

        }

        public ActionResult Browse(string genre)
        {
            var genreModel = db.Genres.Include("Albums")
            .Single(g => g.Name == genre);
            return View(genreModel);
           
        }

        public ActionResult Details(int id)
        {
            var album = db.Albums.Find(id);
            return View(album);
            
        }

    }
}