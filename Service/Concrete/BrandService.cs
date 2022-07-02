using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
using Core.Utilities.Result;
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
        public IResult Add(Brand brand)
        {
            _brandRepository.Add(brand);
            return new SuccessResult();
        }

        public IResult Delete(Brand brand)
        {
            _brandRepository.Delete(brand);
            return new SuccessResult();
        }

        public IDataResult<List<Brand>> Search(BrandSearch searchEntity, Expression<Func<Brand, bool>>? filter = null)
        {
            return new SuccesDataResult<List<Brand>>(_brandRepository.Search(searchEntity, filter));
        }

        public IResult Update(Brand brand)
        {
            _brandRepository.Update(brand);
            return new SuccessResult();
        }
    }
}
