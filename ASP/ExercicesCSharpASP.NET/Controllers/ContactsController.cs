using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace ExercicesCSharpASP.NET.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {

            List<string> contacts = new()
            {
                "Titi",
                "Thibaud",
                "Tibo",
            };


            ViewData["message"] = "message depuis Index";

            List<string> TestBag = new()
            {
                "Bag",
                "Sac",
            };

            ViewBag.TestBags = TestBag;

            return View(contacts);
        }
            public IActionResult Details(int id)
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}
