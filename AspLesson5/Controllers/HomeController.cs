using Microsoft.AspNetCore.Mvc;

namespace AspLesson5.Controllers
{
    public class HomeController : Controller
    {
        public const string key = "def";
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value, DateTime date)
        {
            CookieOptions options = new CookieOptions();
            options.Expires = date;
            Response.Cookies.Append(key, value, options);
            return RedirectToAction("Index");
        }

        public IActionResult GetValue()
        {
            string value = Request.Cookies[key];
            return View(value as object);
        }
    }
}
