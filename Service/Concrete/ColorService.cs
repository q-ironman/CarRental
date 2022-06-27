using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DependencyResolvers.PrimativeWay;
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
        public void Add(Color color)
        {
            _colorRepository.Add(color);
        }

        public void Update(Color color)
        {
            _colorRepository.Update(color);
        }

        public void Delete(Color color)
        {
            _colorRepository.Delete(color);
        }

        public List<Color> Search(ColorSearch searcEntity, Expression<Func<Color, bool>>? filter = null)
        {
            return _colorRepository.Search(searcEntity, filter);
        }
    }
}
