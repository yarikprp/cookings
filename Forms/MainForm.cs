using kulinaria_app_v2.Classes;
using kulinaria_app_v2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = kulinaria_app_v2.Classes.Type;

namespace kulinaria_app_v2.Forms
{
    public partial class MainForm : Form
    {
        List<Dish> dishes = new List<Dish>();
        public static List<Type> types = new List<Type>();

        int selectedRowIndex;
        List<DishStructure> dishStruct = new List<DishStructure>();

        List<Dish> dishSearch = new List<Dish>();

        int closingFlag = 0;

        public MainForm()
        {
            InitializeComponent();
            dataGridViewDishes.Columns[0].DataPropertyName = "Id";
            dataGridViewDishes.Columns[1].DataPropertyName = "Image";
            dataGridViewDishes.Columns[2].DataPropertyName = "DishName";
            dataGridViewDishes.Columns[3].DataPropertyName = "DishType";
            dataGridViewDishes.Columns[4].DataPropertyName = "DishBase";
            dataGridViewDishes.Columns[5].DataPropertyName = "DishExit";
            dataGridViewDishes.Columns[0].Visible = false;

            UpdateRecordsInfo();
        }

        async Task ViewAllDishes()
        {
            dishes = await DishFromDb.LoadDishes();
            dataGridViewDishes.DataSource = dishes;
            UpdateRecordsInfo();
        }

        private void UpdateRecordsInfo()
        {
            int totalRecords = dishes.Count;
            int shownRecordsCount = dataGridViewDishes.Rows.Count;
            selectLabel.Text = $"{shownRecordsCount} из {totalRecords}";
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await ViewAllDishes();

            types = await TypeFromDb.LoadTypes();

            types.Insert(0, new Type(0, "Все"));

            comboBoxTypeOfDish.DataSource = types;

            comboBoxTypeOfDish.DisplayMember = "TypeName";
            comboBoxTypeOfDish.ValueMember = "Id";

            switch (AuthorisationForm.CurrentUser.RoleId)
            {
                case 2:
                    добавитьБлюдоToolStripMenuItem.Visible = false;
                    удалитьБлюдоToolStripMenuItem.Visible = false;
                    пользователиToolStripMenuItem.Visible = false;
                    break;
                case 3:
                    пользователиToolStripMenuItem.Visible = false;
                    добавитьПродуктToolStripMenuItem.Visible = false;
                    break;
            }

            fIOToolStripMenuItem.Text = AuthorisationForm.CurrentUser.FirstName + " " + AuthorisationForm.CurrentUser.LastName;
        }

        private async void comboBoxTypeOfDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypeOfDish.SelectedIndex == 0)
            {
                await ViewAllDishes();
            }
            else
            {
                dishes = await DishFromDb.FilterDishesByType(comboBoxTypeOfDish.SelectedIndex);

                dataGridViewDishes.DataSource = dishes;

                UpdateRecordsInfo();
            }
        }

        List<Dish> SearchDishes(string searchString)
        {
            dishSearch.Clear();

            foreach (Dish item in dishes)
            {
                if (item.DishName.StartsWith(searchString) || item.DishBase.StartsWith(searchString))
                {
                    dishSearch.Add(item);
                }
            }

            return dishSearch;
        }

        private void textBoxSearchOfDish_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchOfDish.Text.Length != 0)
            {
                dataGridViewDishes.DataSource = SearchDishes(textBoxSearchOfDish.Text);
            }
            else
            {
                dataGridViewDishes.DataSource = dishes;
            }


            UpdateRecordsInfo();
        }

        void PrintDishStructure(List<DishStructure> structures, string DishName)
        {
            ClearDishStructure();

            labelDishName.Text = DishName;

            foreach (DishStructure structure in structures)
            {
                listBoxStructure.Items.Add(structure.Prod_Name + ", " + structure.Weight);
            }
        }

        void ClearDishStructure()
        {
            listBoxStructure.Items.Clear();
            labelDishName.Text = string.Empty;
        }

        private async void dataGridViewDishes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDishes.DataSource == dishes)
            {
                selectedRowIndex = dataGridViewDishes.CurrentRow.Index;
                dishStruct = await DishFromDb.DishStructureFromDb(dishes[selectedRowIndex].Id);
                PrintDishStructure(dishStruct, dishes[selectedRowIndex].DishName);
            }
            else
            {
                selectedRowIndex = dataGridViewDishes.CurrentRow.Index;
                dishStruct = await DishFromDb.DishStructureFromDb(dishSearch[selectedRowIndex].Id);
                PrintDishStructure(dishStruct, dishSearch[selectedRowIndex].DishName);
            }
        }

        private void добавитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishAddForm dishAdd = new DishAddForm();
            Hide();
            DialogResult res = dishAdd.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Cancel)
            {
                Show();
            }
        }

        private async void удалитьБлюдоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewDishes.DataSource == dishes)
            {
                string warning = "Вы действительно хотите удалить блюдо " + dishes[selectedRowIndex].DishName + "?";

                DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    await DishFromDb.DeleteDish(dishes[selectedRowIndex].Id);
                    ClearDishStructure();
                    dataGridViewDishes.DataSource = await DishFromDb.LoadDishes();
                }
            }
            else
            {
                string warning = "Вы действительно хотите удалить блюдо " + dishSearch[selectedRowIndex].DishName + "?";

                DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    await DishFromDb.DeleteDish(dishSearch[selectedRowIndex].Id);
                    ClearDishStructure();
                    dataGridViewDishes.DataSource = await DishFromDb.LoadDishes();
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closingFlag == 1)
            {
                Application.Exit();
            }
            else
            {
                Application.OpenForms[0].Show();
            }
        }

        private void редактироватьПрофильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfileEditForm profileEditForm = new ProfileEditForm();
            DialogResult res = profileEditForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                fIOToolStripMenuItem.Text = AuthorisationForm.CurrentUser.FirstName + " " + AuthorisationForm.CurrentUser.LastName;
            }
        }

        private void сменитьПарольToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChangeForm passwordChange = new PasswordChangeForm();
            DialogResult result = passwordChange.ShowDialog();

            if (result == DialogResult.OK)
            {
                Application.OpenForms[0].Show();
                Close();
            }
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorisationForm.CurrentUser = null;
            Application.OpenForms[0].Show();
            Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closingFlag = 1;
            Close();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersControlForm usersControlForm = new UsersControlForm();
            Hide();

            DialogResult res = usersControlForm.ShowDialog();
            if (res == DialogResult.OK)
            {
                Show();
            }
        }

        private void просмотрПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            Hide();
            DialogResult result = productsForm.ShowDialog();

            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void добавитьПродуктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(1);
            Hide();
            DialogResult result = addProductForm.ShowDialog();

            if ((result == DialogResult.OK || result == DialogResult.Cancel) && addProductForm.whereIsCalled == 1)
            {
                Show();
            }
        }

        private void рецептToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceiptForm receiptForm = new ReceiptForm();
            Hide();
            DialogResult result = receiptForm.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void поискПоКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishSearchByCriteriasForm dishSearchByCriteriasForm = new DishSearchByCriteriasForm();
            Hide();
            DialogResult result = dishSearchByCriteriasForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                Show();
            }
        }

        private void DataGridViewDishes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewDishes.Columns["Exit"].Index)
            {
                var cell = dataGridViewDishes.Rows[e.RowIndex].Cells["Exit"];
                if (cell.Value != null && int.TryParse(cell.Value.ToString(), out int weight))
                {
                    if (weight > 200)
                    {
                        dataGridViewDishes.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White;
                    }
                }
            }
        }

    }
}
