using ExercicesCSharpASP.NET.Models;
using System.Diagnostics.Metrics;
using System.Net;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ExercicesCSharpASP.NET.Data
{

    public class FakeContactDb // représente une fausse base de données(équivalent à un DbContext ou un Repository)
    {
        private List<Contact> _contacts; // équivalent de la base de données
        private int _lastId = 0; // pour faire un équivalent d'IDENTITY ou AUTO INCREMENT

        public FakeContactDb()
        {
            _contacts = new List<Contact>() // équivalent du data seed (données par défaut)
            {
    new Contact { Id = ++_lastId, Name = "Thibaud", Email = "Thibaud@gmail.com", PhoneNumber = "07070707", Address = "Address1", City = "Carvin", Region = "HDF", PostalCode = "191919", Country = "France" },
    new Contact { Id = ++_lastId, Name = "John", Email = "john@example.com", PhoneNumber = "12345678", Address = "Address2", City = "City2", Region = "Region2", PostalCode = "987654", Country = "USA" },
    new Contact { Id = ++_lastId, Name = "Alice", Email = "alice@example.com", PhoneNumber = "87654321", Address = "Address3", City = "City3", Region = "Region3", PostalCode = "456789", Country = "Canada" },
    new Contact { Id = ++_lastId, Name = "Bob", Email = "bob@example.com", PhoneNumber = "55555555", Address = "Address4", City = "City4", Region = "Region4", PostalCode = "333333", Country = "UK" },
    new Contact { Id = ++_lastId, Name = "Eva", Email = "eva@example.com", PhoneNumber = "99999999", Address = "Address5", City = "City5", Region = "Region5", PostalCode = "111111", Country = "Australia" }
};
        }

        public List<Contact> GetAll()
        {
            return _contacts;
        }

        public Contact? GetById(int id)
        {
            return _contacts.FirstOrDefault(c => c.Id == id);
        }

        public bool Add(Contact contact)
        {
            contact.Id = ++_lastId;
            _contacts.Add(contact);
            return true; // l'ajout s'est bien passé
        }

        public bool Edit(Contact contact)
        {
            var contactFromDb = GetById(contact.Id);

            if (contactFromDb == null)
                return false;

            contactFromDb.Name = contact.Name;
            contactFromDb.Email = contact.Email;
            contactFromDb.PhoneNumber = contact.PhoneNumber;
            contactFromDb.Address = contact.Address;
            contactFromDb.City = contact.City;
            contactFromDb.Region = contact.Region;
            contactFromDb.PostalCode = contact.PostalCode;
            contactFromDb.Country = contact.Country;

            return true;
        }

        public bool Delete(int id)
        {
            var contact = GetById(id);

            if (contact == null)
                return false;

            _contacts.Remove(contact);

            return true;
        }
    }
}
