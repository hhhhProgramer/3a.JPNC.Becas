using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Control
{
    public class SQLRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext context;
        protected DbSet<T> entities;

        public SQLRepository(AppDbContext context)
        {
            this.context = context;
            this.entities = context.Set<T>();
        }


        public void Delete(T entity)
        {
            if(entity == null) throw new ArgumentNullException("Entity");
            if(entity.Id < 0) throw new ArgumentNullException("Entity");

            var Entity = entities.Attach(entity);
            Entity.State = EntityState.Deleted;
        }

        public T Get(long id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public DbSet<T> GetContex()
        {
            return entities;
        }

        public int Insert(T entity)
        {
            if(entity == null) throw new ArgumentNullException("Entity");

            entities.Add(entity);
            context.SaveChanges();
            return entity.Id;
        }
    }
}