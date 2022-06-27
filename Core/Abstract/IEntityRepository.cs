using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Abstract
{
    public interface IEntityRepository<T,TSearch> where T : class,IEntity,new()
    where TSearch : class,IEntitySearch,new()

    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> Search(TSearch searchEntity, Expression<Func<T, bool>>? filter = null);
    }
}
