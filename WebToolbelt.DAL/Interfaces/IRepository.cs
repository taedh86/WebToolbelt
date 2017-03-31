using System.Collections.Generic;

namespace WebToolbelt.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Delete(int id);
        void Update(T entity);
        void Save();
    }
}
