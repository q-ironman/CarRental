
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository.Abstract
{
    public interface IEntityRepositoryBase<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> Search(Expression<Func<T, bool>>? filter = null);

    }
}
