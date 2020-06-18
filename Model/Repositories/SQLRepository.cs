using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace Model.Repositories
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext context;
        private DbSet<T> entities;

        public SQLRepository(AppDbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();


        }
        public void Delete(T entity)
        {
            if(entity == null) throw new ArgumentNullException("Entity");
            if(entity.id < 0) throw new ArgumentNullException("Entity");

            var Entity = entities.Attach(entity);
            Entity.State = EntityState.Deleted;
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(x => x.id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public int Insert(T entity)
        {
            if(entity == null) throw new ArgumentNullException("Entity");

            entities.Add(entity);
            context.SaveChanges();
            return entity.id;
        }
    }
}