using Microsoft. AspNetCore. Mvc;

namespace comic_book_gallery. Controllers
    {
    public class ComicBooksController : Controller
        {
        public ActionResult Detail()
           
            {
            if (DateTime. Today. DayOfWeek == DayOfWeek. Monday)
                {
                return Redirect("/");
                }
             return Content("Hello from comic book controllers");
            }
        }
    }
