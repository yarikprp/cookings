using kulinaria_app_v2.Classes;
using kulinaria_app_v2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_app_v2.Forms
{
    public partial class ProductsForm : Form
    {

        int selectedProd;
        List<Product> products = new List<Product>();
        List<Product> searchedProd = new List<Product>();

        public ProductsForm()
        {
            InitializeComponent();

            dataGridViewProducts.Columns[0].DataPropertyName = "Id";
            dataGridViewProducts.Columns[1].DataPropertyName = "Name";
            dataGridViewProducts.Columns[2].DataPropertyName = "Protein";
            dataGridViewProducts.Columns[3].DataPropertyName = "Fats";
            dataGridViewProducts.Columns[4].DataPropertyName = "Carboh";

            dataGridViewProducts.Columns[0].Visible = false;
        }

        private async void ProductsForm_Load(object sender, EventArgs e)
        {
            products = await ProductsFromDb.GetProducts();
            dataGridViewProducts.DataSource = products;
        }

        List<Product> SearchProd(string searchString)
        {
            searchedProd.Clear();

            foreach (Product product in products)
            {
                if (product.Name.StartsWith(searchString))
                {
                    searchedProd.Add(product);
                }
            }

            return searchedProd;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length != 0 && !textBoxSearch.Text.Contains(" "))
            {
                dataGridViewProducts.DataSource = SearchProd(textBoxSearch.Text);
            }
            else
            {
                dataGridViewProducts.DataSource = products;
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            selectedProd = dataGridViewProducts.CurrentCell.RowIndex;

            if (dataGridViewProducts.DataSource == products)
            {
                string warning = "Вы действительно хотите удалить продукт " + products[selectedProd].Name + "?";

                DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    await ProductsFromDb.DeleteProduct(products[selectedProd].Id);
                    products = await ProductsFromDb.GetProducts();
                    dataGridViewProducts.DataSource = products;
                }
            }
            else
            {
                string warning = "Вы действительно хотите удалить продукт " + searchedProd[selectedProd].Name + "?";

                DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    await ProductsFromDb.DeleteProduct(searchedProd[selectedProd].Id);
                    products = await ProductsFromDb.GetProducts();
                    dataGridViewProducts.DataSource = products;
                }
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(0);
            Hide();
            DialogResult result = addProductForm.ShowDialog();
            
            if ((result == DialogResult.OK || result == DialogResult.Cancel) && addProductForm.whereIsCalled == 0)
            {
                products = await ProductsFromDb.GetProducts();
                dataGridViewProducts.DataSource = products;
                Show();
            }
        }
    }
}
