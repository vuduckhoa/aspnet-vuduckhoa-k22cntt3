using lesson06.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lesson06.Controllers
{
    public class VdkSongController : Controller
    {
        private static List<VdkSong> pvvSongs = new List<VdkSong>()
        {
          new VdkSong{ Id = 221090032, VdkTitle = "Vu Duc Khoa", VdkAuthor = "k22cntt3", VdkArtist = "NTU", VdkYearRelease="2020"},
          new VdkSong{ Id = 1, VdkTitle = "Vu Duc khoa", VdkAuthor = "k22cnt3", VdkArtist = "NTU", VdkYearRelease="2020"}
        };

        // GET: VdkSong
        public ActionResult VdkIndex()
        {
            return View(VdkSongs);
        }
        public ActionResult VdkCreate() 
        {
            var Vdksong = new VdkSong();
            return View(Vdksong);
        }
    }
}