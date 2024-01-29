using Microsoft.AspNetCore.Mvc;

namespace ExercicesCSharpASP.NET.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }

        List<string> contactsList = new List<string> { "Titi", "Thibaud", "tibo" };
        public string ContactsAfficher()
        {
            string affiche = "Je suis la page pour afficher les contacts :";

            string contacts = "";
            for (int i = 0; i < contactsList.Count; i++)
            {
                contacts += contactsList[i];
                if (i < contactsList.Count - 1)
                    contacts += ", ";
            }

            return $"{affiche} {contacts}";
        }

        public string AfficherUnContacts(string contact)
        {
            return $" {contact}";
        }

        public string AjouterUnContacts(string contact)
        {
            contactsList.Add(contact);

            return $"{contact} ajouté";
        }
    }
}
