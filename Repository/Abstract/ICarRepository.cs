using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Abstract;
using Entity.Concrete.Dtos;

namespace Repository.Abstract
{
    public interface ICarRepository : IEntityRepository<Car,CarSearch>
    {
        List<CarDetailsDto> SearchDetail(CarSearch searchEntity, Expression<Func<CarDetailsDto,bool>>? filter = null);

    }
}
