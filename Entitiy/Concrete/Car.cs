using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete
{
    public class Car : IEntity
    {
        private int _id;
        private int _brandId;
        private int _colorId;
        private short _modelYear;
        private decimal _dailyPrice;
        string _description;
        public int Id
        {
            get => _id;
            set => _id = value;
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

        public string Description
        {
            get => _description;
            set => _description = value ?? throw new ArgumentNullException(nameof(value));
        }

        
    }
}
