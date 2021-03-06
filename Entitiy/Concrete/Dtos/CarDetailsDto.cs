using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete.Dtos
{
    public class CarDetailsDto : IDto
    {
        private string _description;
        private string _brandName;
        private string _colorName;
        private decimal _dailyPrice;
        private short _modelYear;
        private int _id;
        private int _brandId;
        private int _colorId;

        

        public int Id
        {
            get => _id;
            set => _id = value;
        }


        public string BrandName
        {
            get => _brandName;
            set => _brandName = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public short ModelYear
        {
            get => _modelYear;
            set => _modelYear = value;
        }
        public decimal DailyPrice
        {
            get => _dailyPrice;
            set => _dailyPrice = value;
        }

        public string ColorName
        {
            get => _colorName;
            set => _colorName = value;
        }

        public int BrandId
        {
            get => _brandId;
            set => _brandId = value;
        }

        public int ColorId
        {
            get => _colorId;
            set => _colorId = value;
        }


    }
}
