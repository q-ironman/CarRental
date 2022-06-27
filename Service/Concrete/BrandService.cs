using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
using Entity.Concrete.Brand;
using Repository.Abstract;
using Service.Abstract;

namespace Service.Concrete
{
    public class BrandService : IBrandService
    {
        private IBrandRepository _brandRepository;
        public BrandService()
        {
            _brandRepository = ServiceActivator.Get<IBrandRepository>();
        }
        public void Add(Brand brand)
        {
            _brandRepository.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brandRepository.Delete(brand);
        }

        public List<Brand> Search(BrandSearch searchEntity, Expression<Func<Brand, bool>>? filter = null)
        {
            return _brandRepository.Search(searchEntity, filter);
        }

        public void Update(Brand brand)
        {
            _brandRepository.Update(brand);
        }
    }
}
