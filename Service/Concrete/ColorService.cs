using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
using Core.Utilities.Result;
using Entity.Concrete;
using Entity.Concrete.Color;
using Repository.Abstract;
using Service.Abstract;

namespace Service.Concrete
{
    public class ColorService : IColorService
    {
        IColorRepository _colorRepository;
        public ColorService()
        {
            _colorRepository = ServiceActivator.Get<IColorRepository>();
        }
        public IResult Add(Color color)
        {
            _colorRepository.Add(color);
            return new SuccessResult();
        }

        public IResult Update(Color color)
        {
            _colorRepository.Update(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorRepository.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> Search(ColorSearch searcEntity, Expression<Func<Color, bool>>? filter = null)
        {
            return new SuccesDataResult<List<Color>>(_colorRepository.Search(searcEntity, filter));
        }
    }
}
