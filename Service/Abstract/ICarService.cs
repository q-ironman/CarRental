using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;
using Entity.Concrete;
using Entity.Concrete.Dtos;

namespace Service.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> Search(CarSearch searcEntity, Expression<Func<Car, bool>>? filter = null);
        IDataResult<List<CarDetailsDto>> SearchDetails(CarSearch searcEntity = null, Expression<Func<CarDetailsDto, bool>>? filter = null);
    }
}
