using Microsoft.AspNetCore.Mvc;

namespace AspLesson5.Controllers
{
    public class CounterController : Controller
    {
        public static string key = "guidCodeUser";
        //public static int counter;
        public static List<Guid> guids;

        static CounterController()
        {
            guids = new List<Guid>();
        }
        public IActionResult Count()
        {
            if(guids.Count==0)
            return View(0);
            
            return View(guids.Count);
        }
        [HttpPost]
        public IActionResult Increase()
        {
            string userGuid = HttpContext.Session.GetString(key);
            if (string.IsNullOrEmpty(userGuid))
            {
                Guid guid = Guid.NewGuid();
                guids.Add(guid);
                userGuid = guid.ToString();
                HttpContext.Session.SetString(key, userGuid);
            }

            return Ok(guids.Count);
        }
        [HttpPost]
        public IActionResult Decrease()
        {
            Guid.TryParse((HttpContext.Session.GetString(key)),out Guid userGuid );
            guids.Remove(userGuid);
            return Ok(guids.Count);
        }
    }

}
