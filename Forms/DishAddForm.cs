using kulinaria_app_v2.Classes;
using kulinaria_app_v2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_app_v2.Forms
{
    public partial class DishAddForm : Form
    {
        string picFileName = "picture.jpg";

        public DishAddForm()
        {
            InitializeComponent();
            pictureBoxDishImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDishImage.Image = Image.FromFile(@"..\..\Images\picture.jpg");
        }

        private async void DishAddForm_Load(object sender, EventArgs e)
        {
            LoadTypes();
            await LoadProducts();
            await LoadBases();
        }

        void LoadTypes()
        {
            comboBoxType.DisplayMember = "TypeName";
            comboBoxType.ValueMember = "TypeName";
            comboBoxType.DataSource = MainForm.types;
        }

        async Task LoadProducts()
        {
            comboBoxProducts.DisplayMember = "Name";
            comboBoxProducts.ValueMember = "Name";
            comboBoxProducts.DataSource = await ProductsFromDb.GetProducts();
        }

        async Task LoadBases()
        {
            comboBoxBase.DisplayMember = "Name";
            comboBoxBase.ValueMember = "Name";
            comboBoxBase.DataSource = await BaseFromDb.GetBases();
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialogImage.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(openFileDialogImage.FileName);
                picFileName = Path.GetFileName(openFileDialogImage.FileName);
                string distinPath = @"..\..\Images\" + picFileName;

                if (!File.Exists(distinPath))
                {
                    fileInfo.CopyTo(distinPath);
                }

                pictureBoxDishImage.Image = Image.FromFile(distinPath);
            }
        }

        private void buttonAddProd_Click(object sender, EventArgs e)
        {
            if (!IsDuplicateRows(comboBoxProducts.Text))
            {
                dataGridViewProducts.Rows.Add(comboBoxProducts.Text, textBoxProdWeight.Text);
            }
        }

        bool IsDuplicateRows(string selectedProd)
        {
            bool isDuplicate = false;

            for (int i = 0; i < dataGridViewProducts.RowCount; i++)
            {
                if (dataGridViewProducts.Rows[i].Cells[0].Value != null && dataGridViewProducts.Rows[i].Cells[0].Value.ToString() == selectedProd)
                {
                    isDuplicate = true;
                    MessageBox.Show("Такой продукт уже существует");
                    break;
                }
            }

            return isDuplicate;
        }

        private void buttonDelProd_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows != null)
            {
                dataGridViewProducts.Rows.RemoveAt(dataGridViewProducts.CurrentRow.Index);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            string picPath = @"..\..\Images\" + picFileName;

            Dish newDish = new Dish(0, textBoxDishName.Text, comboBoxType.SelectedValue.ToString(), comboBoxBase.SelectedValue.ToString(), int.Parse(textBoxProdWeight.Text), picPath);

            List<DishStructure> structure = new List<DishStructure>();

            for (int i = 0; i < dataGridViewProducts.RowCount - 1; i++)
            {
                structure.Add(new DishStructure(0, dataGridViewProducts.Rows[i].Cells["Column1"].Value.ToString(), Convert.ToInt32(dataGridViewProducts.Rows[i].Cells["Column2"].Value)));
            }

            await DishFromDb.AddNewDish(newDish, structure, MainForm.types[comboBoxType.SelectedIndex].Id, picPath);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
