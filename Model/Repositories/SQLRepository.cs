using System.Collections.Generic;

namespace Model.Repositories
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        public void Delete(T entity)
        {
            throw new System.NotImplementedException();
        }

        public T Get(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}