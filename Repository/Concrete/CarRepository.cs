using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Repository.EntityFramework;
using Entity.Concrete;
using Entity.Concrete.Dtos;
using Repository.Abstract;

namespace Repository.Concrete
{
    public class CarRepository : EfBaseRepository<Car, CarContext>,ICarRepository
    {
        public List<Car> Search(CarSearch searchEntity, Expression<Func<Car, bool>>? filter)
        {
            var res = base.Search(filter).AsQueryable();

            if (searchEntity.Id.HasValue)
            {
                res = res.Where(c => c.Id == searchEntity.Id);
            }
            if (searchEntity.BrandId.HasValue)
                res = res.Where(c => c.BrandId == searchEntity.BrandId);
            if (searchEntity.ModelYear.HasValue)
            {
                res=res.Where(c => c.ModelYear == searchEntity.ModelYear);
            }
            if (!string.IsNullOrEmpty(searchEntity.Description))
                res = res.Where(c => c.Description == searchEntity.Description);

            if (searchEntity.ColorId.HasValue)
            {
                res = res.Where(c => c.ColorId == searchEntity.ColorId);
            }
            return res.ToList();
        }

        public List<CarDetailsDto> SearchDetail(CarSearch searchEntity, Expression<Func<CarDetailsDto,bool>>? filter = null)
        {
            using (CarContext db = new CarContext())
            {
                var res = from c in db.Car
                          join b in db.Brand 
                              on c.BrandId equals b.Id
                          join co in db.Color
                              on c.ColorId equals co.Id
                          where ((!searchEntity.BrandId.HasValue || searchEntity.BrandId == c.BrandId) && (!searchEntity.ColorId.HasValue || searchEntity.ColorId == c.ColorId) && (!searchEntity.ModelYear.HasValue || searchEntity.ModelYear == c.ModelYear)
                                  && (string.IsNullOrEmpty(searchEntity.Description) || c.Description.Contains(searchEntity.Description)))
                              select new CarDetailsDto
                              {
                                  Id = c.Id,
                                  BrandName = b.Name,
                                  ColorName = co.Name,
                                  Description = c.Description,
                                  DailyPrice = c.DailyPrice,
                                  ModelYear = c.ModelYear,
                                  BrandId = b.Id,
                                  ColorId = co.Id
                              };
                if (filter != null)
                    res = res.Where(filter);
                return res.ToList();

            }
        }
    }
}
