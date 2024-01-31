using Microsoft.AspNetCore.Mvc;
using Playtypuces.Data;
using Playtypuces.Models;
using System.Security.Cryptography;

namespace Playtypuces.Controllers
{
    public class PlaytypucesController : Controller
    {
        private FakeDb _fakeDb;

        public PlaytypucesController(FakeDb fakeDb)
        {
            _fakeDb = fakeDb;
        }
        public IActionResult Index()
        {
            return View(_fakeDb.GetAll());
        }

        public IActionResult Details(int id)
        {

            Playtypuce? playtypuces = _fakeDb.GetById(id);

            return View(playtypuces);
        }

        public static string RandomString(string chars, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public IActionResult Delete(int id)
        {

            _fakeDb.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult AddRandom()
        {
            string name = "";
            string sexe = "";

            Random aleatoire = new Random();
            int TailleName = aleatoire.Next(3, 13);
            int age = aleatoire.Next(0, 16);
            int sexeRandom = aleatoire.Next(1, 3);
            int CouleurRandom = aleatoire.Next(1, 5);
            

            for (int i = 0; i < TailleName; i++)
            {
                if (i % 2 == 0)
                {
                    name += RandomString("bcdfghjklmnpqrstvwxyz", 1);
                }
                else
                {
                    name += RandomString("aeiou", 1);
                }
            }

            name = char.ToUpper(name[0]) + name.Substring(1);


            if (sexeRandom == 1)
            {
                sexe = "Mâle";
            }
            else
            {
                sexe = "Femelle";
            }

            string couleur = "";

            switch (CouleurRandom)
            {
                case 1:
                    couleur = "Doré";
                    break;
                case 2:
                    couleur = "Rayé";
                    break;
                case 3:
                    couleur = "Gris";
                    break;
                case 4:
                    couleur = "Marron";
                    break;
                default:
                    couleur = "Inconnue";
                    break;
            }

            Playtypuce? random = new Playtypuce()
            {
                Name = name,
                Age = age,
                Colour = couleur,
                Gender = sexe
            };



            _fakeDb.Add(random);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddListe(Playtypuce playtypuce)
        {
            _fakeDb.Add(playtypuce);

            return RedirectToAction(nameof(Index));
        }
    }
}
