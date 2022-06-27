using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Entity.Concrete.Color;

namespace Service.Abstract
{
    public interface IColorService 
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
        List<Color> Search(ColorSearch searcEntity, Expression<Func<Color, bool>>? filter = null);
    }
}
