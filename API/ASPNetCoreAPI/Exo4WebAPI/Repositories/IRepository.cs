using System.Linq.Expressions;

namespace Exo4WebAPI.Repositories
{
    public interface IRepository<TEntity> 
    {
        bool Add(TEntity animal);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
        TEntity? GetByNom(string nom);
        bool Update(TEntity animal);
        bool Delete(int id);
    }
}