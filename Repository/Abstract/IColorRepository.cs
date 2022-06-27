using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Entity.Concrete.Color;

namespace Repository.Abstract
{
    public interface IColorRepository : IEntityRepository<Color,ColorSearch>
    {

    }
}
