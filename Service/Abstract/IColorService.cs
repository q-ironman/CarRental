using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entity.Concrete;
using Entity.Concrete.Color;

namespace Service.Abstract
{
    public interface IColorService 
    {
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
        IDataResult<List<Color>> Search(ColorSearch searcEntity, Expression<Func<Color, bool>>? filter = null);
    }
}
