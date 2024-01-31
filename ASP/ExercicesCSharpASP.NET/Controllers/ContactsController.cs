using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;
using ExercicesCSharpASP.NET.Models;
using ExercicesCSharpASP.NET.Data;

namespace ExercicesCSharpASP.NET.Controllers
{
    public class ContactsController : Controller
    {

        //        private List<Contact> contactsList = new List<Contact>
        //{
        //    new Contact( 1, "Thibaud", "Thibaud@gmail.com", "07070707", "Address1", "Carvin", "HDF", "191919", "France"),
        //    new Contact(2, "John", "john@example.com", "12345678", "Address2", "City2", "Region2", "987654", "USA"),
        //    new Contact(3, "Alice", "alice@example.com", "87654321", "Address3", "City3", "Region3", "456789", "Canada"),
        //    new Contact(4 , "Bob", "bob@example.com", "55555555", "Address4", "City4", "Region4", "333333", "UK"),
        //    new Contact( 5, "Eva", "eva@example.com", "99999999", "Address5", "City5", "Region5", "111111", "Australia")
        //};

        private FakeContactDb _fakeContactDb = new FakeContactDb();

        public IActionResult Index()
        {
            Contact? mich = new Contact()
            {
                Name = "Michel",
                Email = "michmich@sfr.fr",
                PhoneNumber = "0606060606",
                Address = "65000",
                City = "Lille",
                Region = "HDF",
                PostalCode = "blablabla",
                Country = "France"
            };

            _fakeContactDb.Add(mich);

            return View(_fakeContactDb.GetAll());
        }
        public IActionResult Details(int id)
        {
            //Contact contact = contactsList.FirstOrDefault(c => c.Id == id);
            Contact? contact = _fakeContactDb.GetById(id);

            return View(contact);
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult AddMichel()
        {
            Contact? mich = new Contact()
            {
            Name = "Michel",
            Email = "michmich@sfr.fr",
            PhoneNumber = "0606060606",
            Address = "65000",
            City = "Lille",
            Region = "HDF",
            PostalCode = "blablabla",
            Country = "France"
        };

            _fakeContactDb.Add(mich);

            return RedirectToAction(nameof(Index));
        }
    }
}
