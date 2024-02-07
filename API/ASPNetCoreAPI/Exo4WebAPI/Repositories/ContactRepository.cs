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
        public bool Add(Contact contact)
        {
            var addedObj = _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
            return addedObj.Entity.Id > 0;
        }

        // READ
        public Contact? GetById(int id)
        {
            return _dbContext.Contacts.Find(id);
        }
        public Contact? Get(Expression<Func<Contact, bool>> predicate)
        {
            return _dbContext.Contacts.FirstOrDefault(predicate);
        }

        public Contact? GetByNom(string nom)
        {
           return _dbContext.Contacts.FirstOrDefault(c => c.Nom == nom);
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
        public bool Update(Contact contact)
        {
            var contactFromDb = GetById(contact.Id);

            if (contactFromDb == null)
                return false;

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

            return _dbContext.SaveChanges() > 0;
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
