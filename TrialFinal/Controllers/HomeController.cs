using TrialFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static LibraryForTrialFinal.Logic.SongProcessor;
using static LibraryForTrialFinal.Logic.ArtistProcessor;

namespace TrialFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AddArtistAndSong()
        {
            ViewBag.Message = "Add an artist here.";

            return View();
        }

        public ActionResult AddASong()
        {
            ViewBag.Message = "Add a song here.";

            return View();
        }

        public ActionResult ViewSongs()
        {
            var data = LoadSongs();
            List<SongModel> songs = new List<SongModel>();

            foreach (var row in data)
            {
                songs.Add(new SongModel
                {
                    SongName = row.SongName,
                    SongLength = row.SongLength,

                });
            }

            return View(songs);
        }

    }
}