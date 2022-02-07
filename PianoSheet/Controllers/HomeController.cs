using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PianoSheet.Models.EF;
using PianoSheet.Models.Models;

namespace PianoSheet.Controllers
{
    public class HomeController : Controller
    {
        MyMusicSheetEntities db = new MyMusicSheetEntities();
        public ActionResult Index()
        {
            var sanphamdb = db.SanPhams.Take(4).ToList();
            return View(sanphamdb);
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
    }
}