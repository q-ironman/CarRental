using Core.DependencyResolvers.PrimativeWay;
using Entity.Concrete;
using Entity.Concrete.Brand;
using Entity.Concrete.Color;
using Service.Abstract;
using Service.Concrete;

namespace CarRental
{
    public partial class Form1 : Form
    {
        ICarService _carService;
        IBrandService _brandService;
        IColorService _colorService;
        public Form1()
        {
            InitializeComponent();
            _carService = ServiceActivator.Get<ICarService>();
            _brandService = ServiceActivator.Get<IBrandService>();
            _colorService = ServiceActivator.Get<IColorService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarSearch srch = new CarSearch{BrandId = null, Description = null, ModelYear = null};
            ColorSearch srchColor = new ColorSearch { Name = null };
            BrandSearch srchBrand = new BrandSearch { Name = null };

            //dataGridView1.DataSource = _brandService.Search(srchBrand,null);
            //dataGridView1.DataSource = _colorService.Search(srchColor);
            dataGridView1.DataSource = _carService.SearchDetails(srch);
        }
    }
}