using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CST_Project_1
{

    public partial class Items : Form
    {
        
        public Items()
        {
            InitializeComponent();
        }

        private void exitApp_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductBrand_lbl_Click(object sender, EventArgs e)
        {

        }

        //SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\kevre\OneDrive\Desktop\CST Milestone 3\GymItemsDb.mdf";Integrated Security=True;Connect Timeout=30");
        private async void AddItem_btn_Click(object sender, EventArgs e)
        {
            // ProductName_txt
            // ProductBrand_txt
            // ProductQuantity_txt
            // ProductPrice_txt
            // comboBox1
            Dictionary< string, object > dict = new Dictionary< String, Object >();
            int.TryParse(ProductQuantity_txt.Text, out int quantity);
            decimal.TryParse(ProductPrice_txt.Text, out decimal price);
            List<int> ids = await Program.Sql.GetEntry< int >(table: Program.Table, column: "id");
            dict.Add("name", ProductName_txt.Text.Stringify());
            dict.Add("brand", ProductBrand_txt.Text.Stringify());
            dict.Add("quantity", quantity);
            dict.Add("price", price);
            dict.Add("category", comboBox1.SelectedIndex + 1);
            await Program.Sql.InsertInto(dict);
            
            await GetProducts();
        }

        private void BindGrid(List<Product> products)
        {
            ItemDisplay_gridview.AutoGenerateColumns = false;
            ItemDisplay_gridview.Rows.Clear();
            ItemDisplay_gridview.Columns.Clear();

            //create the column programatically
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Id",
                DataPropertyName = "Id"
            };
            DataGridViewTextBoxColumn colName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Name",
                DataPropertyName = "Name"
            };
            DataGridViewTextBoxColumn colBrand = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Brand",
                DataPropertyName = "Brand"
            };
            DataGridViewTextBoxColumn colQuantity = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            };
            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Price",
                DataPropertyName = "Price"
            };
            DataGridViewTextBoxColumn colCategory = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "Value",
                HeaderText = "Category",
                DataPropertyName = "Category"
            };

            ItemDisplay_gridview.Columns.Add(colId);
            ItemDisplay_gridview.Columns.Add(colName);
            ItemDisplay_gridview.Columns.Add(colBrand);
            ItemDisplay_gridview.Columns.Add(colQuantity);
            ItemDisplay_gridview.Columns.Add(colPrice);
            ItemDisplay_gridview.Columns.Add(colCategory);

            var productsList = new BindingList<Product>(products); // <-- BindingList

            //Bind BindingList directly to the DataGrid, no need of BindingSource
            ItemDisplay_gridview.DataSource = productsList;
            ItemDisplay_gridview.Refresh();
        }

        private async Task GetProducts() {
            // Get Product Entries
            List<dynamic> lo = await Program.Sql.GetEntry<dynamic>(Program.Table, column: "*");

            List<Product> product = new List<Product>();

            for (int y = 0; y < lo.Count / 6; y++)
            {
                int i = y * 6;
                int Id = lo[i];
                string Name = lo[i + 1];
                string Brand = lo[i + 2];
                int Quantity = (int)lo[i + 3];
                decimal Price = lo[i + 4];
                int Category = (int)lo[i + 5];
                var p = new Product
                {
                    Id = Id,
                    Name = Name,
                    Brand = Brand,
                    Quantity = Quantity,
                    Price = Price,
                    Category = Category
                };
                product.Add(p);
            }
            BindGrid(product);
        }

        private async void Items_Load(object sender, EventArgs e) {
            
            // Get Categories
            List<string> lst = await Program.Sql.GetEntry<string>(table: Program.TableCategory, column: "name");
            
            comboBox1.DataSource = lst;
            comboBox2.DataSource = lst;
            await GetProducts();
        }

        private async void RemoveItem_btn_Click(object sender, EventArgs e) {
            Product data = (Product)ItemDisplay_gridview.CurrentRow.DataBoundItem;
            await Program.Sql.Delete(queryColumn: "id", data.Id);
            await GetProducts();
        }
    }
}
