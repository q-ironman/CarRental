using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Entity.Concrete.Dtos;

namespace Service.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> Search(CarSearch searcEntity, Expression<Func<Car, bool>>? filter = null);
        List<CarDetailsDto> SearchDetails(CarSearch searcEntity = null, Expression<Func<CarDetailsDto, bool>>? filter = null);
    }
}
