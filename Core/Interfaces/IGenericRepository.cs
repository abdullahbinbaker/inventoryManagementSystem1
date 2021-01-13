using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        //Task<T> GetById(object id);
        //Task<T> Insert(T entity);
        ////void Update(T entity);
        //void Delete(T entity);
    }
}
