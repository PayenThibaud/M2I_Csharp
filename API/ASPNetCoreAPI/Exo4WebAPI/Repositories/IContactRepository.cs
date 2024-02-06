using Exo4WebAPI.Models;
using System.Linq.Expressions;

namespace Exo4WebAPI.Repositories
{
    public interface IContactRepository
    {
        bool Add(Contact contact);
        Contact? Get(Expression<Func<Contact, bool>> predicate);
        List<Contact> GetAll();
        List<Contact> GetAll(Expression<Func<Contact, bool>> predicate);
        Contact? GetById(int id);
        Contact? GetByNom(string nom);
        bool Update(Contact animal);
        bool Delete(int id);
    }
}
