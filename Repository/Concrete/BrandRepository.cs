using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Core.Repository.EntityFramework;
using Entity.Concrete.Brand;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class BrandRepository : EfBaseRepository<Brand, CarContext>, IBrandRepository
    {
        public List<Brand> Search(BrandSearch searchEntity, Expression<Func<Brand, bool>>? filter = null)
        {
            var res = base.Search(filter).AsQueryable();

            if (!string.IsNullOrEmpty(searchEntity.Name))
            {
                res = res.Where(b => b.Name == searchEntity.Name);
            }
            return res.ToList();
        }
    }
}
