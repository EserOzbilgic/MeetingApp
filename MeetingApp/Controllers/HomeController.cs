using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int time = DateTime.Now.Hour;
            // ViewBag.greeting = time > 12 ? "Good Afternoon" : "Good Morning";
            // ViewBag.UserName = "John";

            ViewData["greeting"] = time > 12 ? "Good Afternoon" : "Good Morning";
            ViewData["UserName"] = "John";
            return View();
        }
    }
}
