using Microsoft.AspNetCore.Mvc;
using MeetingApp.Models;
using System.Security.Cryptography.X509Certificates;

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
            int UserCount = Repository.Users.Where(info => info.WillAttend == true).Count();
            // ViewData["UserName"] = "John";


            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Paris, Congress Center",
                Date = new DateTime(2026, 11, 23, 11, 0, 0),
                NumberOfParticipants = UserCount
            };

            return View(meetingInfo);
        }
    }
}
