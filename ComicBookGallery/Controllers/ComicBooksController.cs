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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("ComicBooks/Detail");
            }
            return Content("Hello from the comic books controller!");
           
            
        }
    }
}