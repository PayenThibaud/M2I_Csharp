using System.Linq.Expressions;

namespace Exo4WebAPI.Repositories
{
    public interface IRepository<TEntity> 
    {
        bool Add(TEntity animal);
        TEntity? Get(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        TEntity? GetById(int id);
        TEntity? Update(TEntity animal);
        bool Delete(int id);
    }
}