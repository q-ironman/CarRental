using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
using Core.Utilities.Result;
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
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length > 2)
            {
                if (car.DailyPrice > 0)
                {
                    _carRepository.Add(car);
                    return new SuccessResult();
                }
            }

            return new FailResult();


        }

        public IResult Delete(Car entity)
        {
            _carRepository.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> Search(CarSearch searcEntity, Expression<Func<Car, bool>>? filter)
        {
            return new SuccesDataResult<List<Car>>(_carRepository.Search(searcEntity, filter).ToList());
        }

        public IDataResult<List<CarDetailsDto>> SearchDetails(CarSearch searcEntity = null, Expression<Func<CarDetailsDto, bool>>? filter = null)
        {
            return new SuccesDataResult<List<CarDetailsDto>>(_carRepository.SearchDetail(searcEntity, filter));
        }

        public IResult Update(Car car)
        {
            _carRepository.Update(car);
            return new SuccessResult();
        }
    }
}
