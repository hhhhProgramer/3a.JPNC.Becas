using System;
using System.Collections.Generic;

namespace Model.Repositories
{
      public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Int64 id);
        void Insert(T entity);
        void Delete(T entity);
    }
}