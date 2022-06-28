using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Repository.Abstract;
using Repository.Concrete;
using Service.Abstract;

namespace Service.Concrete
{
    public class CarService : ICarService
    {
        ICarRepository _carRepository;
        public CarService()
        {
            _carRepository = ServiceActivator.Get<ICarRepository>();
        }

        public void Add(Car car)
        {
            if (car.Description.Length > 2)
            {
                if (car.DailyPrice > 0)
                {
                    _carRepository.Add(car);
                }
            }
            
        }

        public void Delete(Car entity)
        {
            _carRepository.Delete(entity);
        }

        public List<Car> Search(CarSearch searcEntity, Expression<Func<Car, bool>>? filter)
        {
            return _carRepository.Search(searcEntity, filter).ToList();
        }

        public List<CarDetailsDto> SearchDetails(CarSearch searcEntity = null, Expression<Func<CarDetailsDto, bool>>? filter = null)
        {
            return _carRepository.SearchDetail(searcEntity, filter);
        }

        public void Update(Car car)
        {
            _carRepository.Update(car);
        }
    }
}
