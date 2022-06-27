using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Entity.Concrete.Brand;

namespace Repository.Abstract
{
    public interface IBrandRepository : IEntityRepository<Brand,BrandSearch>
    {
    }
}
