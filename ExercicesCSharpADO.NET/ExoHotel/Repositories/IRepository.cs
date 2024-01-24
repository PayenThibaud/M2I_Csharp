using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoHotel.Repositories
{
    internal interface IRepository<T, Tid> where T : new()
    {
        void Save(T entity);
        List<T> GetAll();
        T? GetOneById(Tid id);
        void Update(T entity);
        void Delete(T entity);
    }
}
