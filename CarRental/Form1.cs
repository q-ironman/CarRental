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
        private CarSearch srch;
        private ColorSearch srchColor;
        private BrandSearch srchBrand;
        public Form1()
        {
            InitializeComponent();
            _carService = ServiceActivator.Get<ICarService>();
            _brandService = ServiceActivator.Get<IBrandService>();
            _colorService = ServiceActivator.Get<IColorService>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            srch = new CarSearch{BrandId = null, Description = null, ModelYear = null};
            srchColor = new ColorSearch { Name = null };
            srchBrand = new BrandSearch { Name = null };

            //dataGridView1.DataSource = _brandService.Search(srchBrand,null);
            //dataGridView1.DataSource = _colorService.Search(srchColor);
            dataGridView1.DataSource = _carService.SearchDetails(srch);
            comboBox_Brand.DisplayMember = "Value";
            comboBox_Color.DisplayMember = "Value";
            comboBox_Brand.Items.Add("All");
            comboBox_Color.Items.Add("All");
            var colors = _colorService.Search(srchColor);
            var brands = _brandService.Search(srchBrand);
            foreach (var brand in brands.Data)
            {
                comboBox_Brand.Items.Add(new KeyValuePair<int, string>(brand.Id, brand.Name));
            }

            foreach (var color in colors.Data)
            {
                comboBox_Color.Items.Add(new KeyValuePair<int, string>(color.Id, color.Name));
            }

            

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            srch.Description = textBox_Name.Text;
            dataGridView1.DataSource = _carService.SearchDetails(srch).Data;
        }

        private void comboBox_Brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Brand.SelectedItem == "All")
            {
                srch.BrandId = null;
            }
            else
            {
                srch.BrandId = ((KeyValuePair<int, string>)comboBox_Brand.SelectedItem).Key;
            }
        }

        private void comboBox_Color_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Color.SelectedItem == "All")
            {
                srch.ColorId = null;
            }
            else
            {
                srch.ColorId = ((KeyValuePair<int, string>)comboBox_Color.SelectedItem).Key;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[2].Value);

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                Form_Add_Update frm = new Form_Add_Update();
                frm.Id = id;
                frm.Mode = true;
                frm.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                Car car2delete = new Car
                {
                    Id = id,
                    BrandId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["BrandId"].Value),
                    ColorId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ColorId"].Value),
                    DailyPrice = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["DailyPrice"].Value),
                    Description = dataGridView1.Rows[e.RowIndex].Cells["Description"].Value.ToString(),
                    ModelYear = Convert.ToInt16(dataGridView1.Rows[e.RowIndex].Cells["ModelYear"].Value)
                };
                _carService.Delete(car2delete);
                button_Search.PerformClick();
            }
        }

        private void button_AddNewCar_Click(object sender, EventArgs e)
        {
            Form_Add_Update form = new Form_Add_Update();
            form.Mode = false;
            form.ShowDialog();
        }
    }
}