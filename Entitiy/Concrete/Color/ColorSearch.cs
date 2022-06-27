using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entity.Concrete.Color
{
    public class ColorSearch : IEntitySearch
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
