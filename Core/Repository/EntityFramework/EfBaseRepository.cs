using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Core.Entities;
using Core.Repository.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.Repository.EntityFramework
{
    public abstract class EfBaseRepository<T, TContext> : IEntityRepositoryBase<T>
        where T : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(T entity)
        {
            using (TContext db = new TContext())
            {
                var entityProcces = db.Entry(entity);
                entityProcces.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (TContext db = new TContext())
            {
                var entityProcces = db.Entry(entity);
                entityProcces.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public List<T> Search(Expression<Func<T, bool>>? filter = null) 
        {
            using (TContext db = new TContext())
            {
                return filter == null ? db.Set<T>().ToList() : db.Set<T>().Where(filter).ToList();
            }
        }

        public void Update(T entity)
        {
            using (TContext db = new TContext())
            {
                var entityProcces = db.Entry(entity);
                entityProcces.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
