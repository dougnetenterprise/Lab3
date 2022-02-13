using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            HttpContext.Session.SetString("bottles", Request.Form["bottles"]);
            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
