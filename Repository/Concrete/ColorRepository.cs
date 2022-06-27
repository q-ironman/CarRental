using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Repository.EntityFramework;
using Entity.Concrete.Color;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class ColorRepository : EfBaseRepository<Color, CarContext>, IColorRepository
    {
        public List<Color> Search(ColorSearch searchEntity, Expression<Func<Color, bool>>? filter)
        {
            var res = base.Search(filter).AsQueryable();
            if (!string.IsNullOrEmpty(searchEntity.Name))
            {
                res = res.Where(c => c.Name==searchEntity.Name);
            }
            return res.ToList();
        }
    }
}
