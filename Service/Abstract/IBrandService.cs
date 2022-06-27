using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete.Brand;

namespace Service.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        List<Brand> Search(BrandSearch searchEntity, Expression<Func<Brand, bool>>? filter = null);
    }
}
