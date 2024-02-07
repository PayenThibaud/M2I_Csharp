using Exo4WebAPI.Data;
using Exo4WebAPI.Models;
using System.Linq.Expressions;

namespace Exo4WebAPI.Repositories
{
    public class ContactRepository : IRepository<Contact>
    {
        private ApplicationDbContext _dbContext;
        public ContactRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CREATE
        public Contact? Add(Contact contact)
        {
            var addEntry = _dbContext.Contacts.Add(contact); // retourne un EntityEntry<Contact> qui enveloppe le nouveau contact créé
            _dbContext.SaveChanges();

            if (addEntry.Entity.Id > 0) // si l'entité est bien ajoutée l'id est > 0
                return addEntry.Entity;

            return null; // erreur lors de l'ajout
        }

        // READ
        public Contact? GetById(int id)
        {
            return _dbContext.Contacts.FirstOrDefault(c => c.Id == id);
        }
        public Contact? Get(Expression<Func<Contact, bool>> predicate)
        {
            return _dbContext.Contacts.FirstOrDefault(predicate);
        }

        public IEnumerable<Contact> GetAll()
        {
            return _dbContext.Contacts;
        }
        public IEnumerable<Contact> GetAll(Expression<Func<Contact, bool>> predicate)
        {
            return _dbContext.Contacts.Where(predicate);
        }

        // UPDATE
        public Contact? Update(Contact contact)
        {
            var contactFromDb = GetById(contact.Id);

            if (contactFromDb == null)
                return null;

            if (contactFromDb.Nom != contact.Nom)
                contactFromDb.Nom = contact.Nom;
            if (contactFromDb.Prenom != contact.Prenom)
                contactFromDb.Prenom = contact.Prenom;
            if (contactFromDb.Sexe1 != contact.Sexe1)
                contactFromDb.Sexe1 = contact.Sexe1;
            if (contactFromDb.DateDeNaissance != contact.DateDeNaissance)
                contactFromDb.DateDeNaissance = contact.DateDeNaissance;
            if (contactFromDb.Avatar != contact.Avatar)
                contactFromDb.Avatar = contact.Avatar;

            if (_dbContext.SaveChanges() == 0)
                return null;

            return contactFromDb;
        }



        // DELETE
        public bool Delete(int id)
        {
            var contact = GetById(id);
            if (contact == null)
                return false;
            _dbContext.Contacts.Remove(contact);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
