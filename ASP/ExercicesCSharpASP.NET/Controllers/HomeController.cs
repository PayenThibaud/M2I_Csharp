using ExercicesCSharpASP.NET.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExercicesCSharpASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public string Test()
        {
            return "Test";
        }

        //?personne=coucou
        public string TestA(string personne)
        {
            return $"Test {personne}";
        }

        public string Compte(int id)
        {
            string chaine = "";
            for (int i = 0; i < id+1; i++)
            {
                chaine += i + ", ";
            }
            return $"Compte : {chaine}!";
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


