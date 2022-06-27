using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete.Brand
{
    public class BrandSearch : IEntitySearch
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
