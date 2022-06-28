using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core.DependencyResolvers.PrimativeWay;
using Entity.Concrete;
using Entity.Concrete.Brand;
using Entity.Concrete.Color;
using Service.Abstract;

namespace CarRental
{
    public partial class Form_Add_Update : Form
    {
        public bool Mode { get; set; }
        public int? Id { get; set; }

        private Car addUpdateCar;
        private CarSearch search;
        private ColorSearch srchColor;
        private BrandSearch srchBrand;
        ICarService _carService;
        IBrandService _brandService;
        IColorService _colorService;
        public Form_Add_Update()
        {
            InitializeComponent();
            _carService = ServiceActivator.Get<ICarService>();
            _brandService = ServiceActivator.Get<IBrandService>();
            _colorService = ServiceActivator.Get<IColorService>();
        }

        private void Form_Add_Update_Load(object sender, EventArgs e)
        {
            srchColor = new ColorSearch { Name = null };
            srchBrand = new BrandSearch { Name = null };

            
            comboBox_Brand.DisplayMember = "Value";
            comboBox_Color.DisplayMember = "Value";
            var colors = _colorService.Search(srchColor);
            var brands = _brandService.Search(srchBrand);
            foreach (var brand in brands)
            {
                comboBox_Brand.Items.Add(new KeyValuePair<int, string>(brand.Id, brand.Name));
            }

            foreach (var color in colors)
            {
                comboBox_Color.Items.Add(new KeyValuePair<int, string>(color.Id, color.Name));
            }

            if (Mode)
            {
                search = new CarSearch
                    { Id = this.Id, BrandId = null, ColorId = null, Description = null, ModelYear = null };
                addUpdateCar = _carService.Search(search)[0];
                comboBox_Brand.SelectedIndex=addUpdateCar.BrandId;
                comboBox_Color.SelectedIndex=addUpdateCar.ColorId;
                textBox_DailyPrice.Text = addUpdateCar.DailyPrice.ToString();
                textBox_Name.Text = addUpdateCar.Description;
                textBox_ModelYear.Text = addUpdateCar.ModelYear.ToString();
                button_AddNewCar.Text = "Update";

            }
        }

        private void button_AddNewCar_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                addUpdateCar.ColorId = ((KeyValuePair<int,string>)comboBox_Color.SelectedItem).Key;
                addUpdateCar.BrandId = ((KeyValuePair<int,string>)comboBox_Brand.SelectedItem).Key;
                addUpdateCar.DailyPrice = Convert.ToDecimal(textBox_DailyPrice.Text);
                addUpdateCar.Description = textBox_Name.Text;
                _carService.Update(addUpdateCar);
            }
            else
            {
                addUpdateCar = new Car();
                addUpdateCar.ColorId = ((KeyValuePair<int, string>)comboBox_Color.SelectedItem).Key;
                addUpdateCar.BrandId = ((KeyValuePair<int, string>)comboBox_Brand.SelectedItem).Key;
                addUpdateCar.Description = textBox_Name.Text;
                addUpdateCar.ModelYear = Convert.ToInt16(textBox_ModelYear.Text);
                addUpdateCar.DailyPrice = Convert.ToDecimal(textBox_DailyPrice.Text);
                _carService.Add(addUpdateCar);

            }
        }
    }
}
