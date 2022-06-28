using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete
{
    public class CarSearch : IEntitySearch
    {
        private int? _id;
        private short? _modelYear;
        private string _description;
        private int? _brandId;
        private int? _colorId;
        public int? Id
        {
            get => _id;
            set => _id = value;
        }
        public int? ColorId
        {
            get => _colorId;
            set => _colorId = value;
        }

        public short? ModelYear
        {
            get => _modelYear;
            set => _modelYear = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public int? BrandId
        {
            get => _brandId;
            set => _brandId = value;
        }

        
    }
}
