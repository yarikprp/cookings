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
    public partial class DishSearchByCriteriasForm : Form
    {
        List<Product> products = new List<Product>();
        List<Dish> dishes = new List<Dish>();
        List<Dish> searched = new List<Dish>();
        

        public DishSearchByCriteriasForm()
        {
            InitializeComponent();

            dataGridViewProducts.Columns[0].DataPropertyName = "Name";
            dataGridViewProducts.Columns[2].DataPropertyName = "Id";
            dataGridViewProducts.Columns[3].DataPropertyName = "Protein";
            dataGridViewProducts.Columns[4].DataPropertyName = "Fats";
            dataGridViewProducts.Columns[5].DataPropertyName = "Carboh";

            dataGridViewProducts.Columns[2].Visible = false;
            dataGridViewProducts.Columns[3].Visible = false;
            dataGridViewProducts.Columns[4].Visible = false;
            dataGridViewProducts.Columns[5].Visible = false;

            dataGridViewDishes.Columns[0].DataPropertyName = "Id";
            dataGridViewDishes.Columns[1].DataPropertyName = "Image";
            dataGridViewDishes.Columns[2].DataPropertyName = "DishName";
            dataGridViewDishes.Columns[3].DataPropertyName = "DishType";
            dataGridViewDishes.Columns[4].DataPropertyName = "DishBase";
            dataGridViewDishes.Columns[5].DataPropertyName = "DishExit";

            dataGridViewDishes.Columns[0].Visible = false;
        }

        private async void DishSearchByCriteriasForm_Load(object sender, EventArgs e)
        {
            products = await ProductsFromDb.GetProducts();
            dishes = await DishFromDb.LoadDishes();

            dataGridViewProducts.DataSource = products;
            dataGridViewDishes.DataSource = dishes;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void buttonInclude_Click(object sender, EventArgs e)
        {
            StringBuilder sqlQuery = new StringBuilder("SELECT DISTINCT dish_id, dish_name, type_name, base_name, base_exit, dish_image" +
                    " FROM public.dishes join public.dish_types on dish_type_id = type_id join public.dish_base" +
                    " on dish_base_id = base_id join scructure on dish_id = dishes_id where ");

            int j = 0;

            for (int i = 0; i < products.Count; i++)
            {
                if (dataGridViewProducts.Rows[i].Cells["Column2"].Value != null)
                {
                    if (dataGridViewProducts.Rows[i].Cells["Column2"].Value.ToString() == true.ToString())
                    {
                        sqlQuery.Append($"products_id = {products[i].Id} or ");
                        j++;
                    }
                }
            }

            if (j != 0)
            {
                sqlQuery.Remove(sqlQuery.Length - 4, 4);
                searched = await DishFromDb.SearchDish(sqlQuery.ToString());
                dataGridViewDishes.DataSource = searched;
            }
            else
            {
                dataGridViewDishes.DataSource = dishes;
            }
        }

        private async void button2NotInclude_Click(object sender, EventArgs e)
        {
            StringBuilder sqlQuery = new StringBuilder("SELECT dish_id, dish_name, type_name, base_name, base_exit, dish_image " +
                "FROM public.dishes join public.dish_types on dish_type_id = type_id join public.dish_base on dish_base_id = base_id " +
                "except select dish_id, dish_name, type_name, base_name, base_exit, dish_image " +
                "FROM public.dishes join public.dish_types on dish_type_id = type_id join public.dish_base on dish_base_id = base_id " +
                "join public.scructure on dish_id = dishes_id where ");

            int j = 0;

            for (int i = 0; i < products.Count; i++)
            {
                if (dataGridViewProducts.Rows[i].Cells["Column2"].Value != null)
                {
                    if (dataGridViewProducts.Rows[i].Cells["Column2"].Value.ToString() == true.ToString())
                    {
                        sqlQuery.Append($"products_id = {products[i].Id} or ");
                        j++;
                    }
                }
            }

            if (j != 0)
            {
                sqlQuery.Remove(sqlQuery.Length - 4, 4);
                searched = await DishFromDb.SearchDish(sqlQuery.ToString());
                dataGridViewDishes.DataSource = searched;
            }
            else
            {
                dataGridViewDishes.DataSource = dishes;
            }
        }
    }
}
