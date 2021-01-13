using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        //IGenericRepository<T> Entity { get; }
        void Save();
    }
}