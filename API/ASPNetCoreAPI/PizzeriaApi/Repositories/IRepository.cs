using System.Linq.Expressions;

namespace PizzeriaApi.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity?> Add(TEntity entity);

        // READ
        Task<TEntity?> Get(int id);
        Task<TEntity?> Get(Expression<Func<TEntity, bool>> predicate);
        Task<IEnumerable<TEntity>> GetAll(); // toutes les entités
        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>> predicate);

        // UPDATE
        Task<TEntity?> Update(TEntity entity);

        // DELETE
        Task<bool> Delete(int id);

    }
}
