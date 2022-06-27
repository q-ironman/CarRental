using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entity.Concrete;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class InMemoryCarRepository //: ICarRepository
    {
        public List<Car> cars = new List<Car>();
        public InMemoryCarRepository()
        {
            cars.Add(new Car{Id = 1,BrandId = 1,ColorId = 1, DailyPrice = 150, Description = "Corolla", ModelYear = 2005});
            cars.Add(new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice = 175, Description = "Corolla", ModelYear = 2010 });
            cars.Add(new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 180, Description = "Civic", ModelYear = 2020 });
            cars.Add(new Car { Id = 4, BrandId = 2, ColorId = 1, DailyPrice = 190, Description = "Accord", ModelYear = 2000 });
            cars.Add(new Car { Id = 5, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "Hilux", ModelYear = 2006 });
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public void Update(Car car)
        {
            var car2Update = cars.SingleOrDefault(c => c.Id == car.Id);
            car2Update.BrandId = car.BrandId;
            car2Update.ColorId= car.ColorId;
            car2Update.DailyPrice = car.DailyPrice;
            car2Update.Description = car.Description;
            car2Update.ModelYear = car.ModelYear;

        }

        public void Delete(Car car)
        {
            var car2Delete = cars.SingleOrDefault(c => c.Id == car.Id);
            cars.Remove(car2Delete);
        }

        public IQueryable<Car> Search(CarSearch searchEntity, Expression<Func<Car, bool>>? filter = null)
        {
            var res = cars.AsQueryable();
            if (filter != null)
            {
                res = res.Where(filter);
            }

            if (searchEntity.BrandId.HasValue)
            {
                res = res.Where(c => c.BrandId == searchEntity.BrandId);
            }

            if (searchEntity.ModelYear.HasValue)
            {
                res = res.Where(c => c.ModelYear == searchEntity.ModelYear);
            }

            if (!string.IsNullOrEmpty(searchEntity.Description))
            {
                res = res.Where(c => c.Description == searchEntity.Description);
            }

            return res;
        }
    }
}
