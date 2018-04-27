using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            //{
            //    return Redirect("ComicBooks/Detail");
            //}
            //return Content("Hello from the comic books controller!");

            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Final issue! <strong>Witness the final</strong> hour</p>";
            ViewBag.artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Letters: Chris Eliopoulos"
            };
            return View();
            
        }
    }
}