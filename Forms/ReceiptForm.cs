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
    public partial class ReceiptForm : Form
    {
        List<Dish> dishes = new List<Dish>();
        List<DishStructure> dishStruct = new List<DishStructure>();
        Receipt receipt;
        int i = 1;

        public ReceiptForm()
        {
            InitializeComponent();
        }

        private async void ReceiptForm_Load(object sender, EventArgs e)
        {
            dishes = await DishFromDb.LoadDishes();
            receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[0].Id);


            labelDishName.Text = dishes[0].DishName;
            if (receipt != null)
            {
                richTextBoxReceipt.Text = receipt.Recipe_text;
            }
            else
            {
                richTextBoxReceipt.Text = "Нет рецепта";
            }

            dishStruct = await DishFromDb.DishStructureFromDb(dishes[i - 1].Id);
            PrintDishStructure(dishStruct, dishes[i - 1].DishName);
        }

        private async void buttonPrev_Click(object sender, EventArgs e)
        {
            if (i <= 1)
            {
                buttonPrev.Enabled = false;
                buttonNext.Enabled = true;

                labelDishName.Text = dishes[i - 1].DishName;

                dishStruct = await DishFromDb.DishStructureFromDb(dishes[i - 1].Id);
                PrintDishStructure(dishStruct, dishes[i - 1].DishName);

                receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[i - 1].Id);
                if (receipt != null)
                {
                    richTextBoxReceipt.Text = receipt.Recipe_text;
                }
                else
            {
                richTextBoxReceipt.Text = "Нет рецепта";
            }
            }
            else if (i > 1)
            {
                buttonNext.Enabled = true;
                buttonPrev.Enabled = true;
                i--;

                labelDishName.Text = dishes[i - 1].DishName;

                dishStruct = await DishFromDb.DishStructureFromDb(dishes[i - 1].Id);
                PrintDishStructure(dishStruct, dishes[i - 1].DishName);

                receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[i - 1].Id);
                if (receipt != null)
                {
                    richTextBoxReceipt.Text = receipt.Recipe_text;
                }
                else
                {
                    richTextBoxReceipt.Text = "Нет рецепта";
                }
            }
        }

        void ClearDishStructure()
        {
            listBoxStructure.Items.Clear();
            labelDishName.Text = string.Empty;
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

        private async void buttonNext_Click(object sender, EventArgs e)
        {
            if (i >= dishes.Count)
            {
                buttonNext.Enabled = false;
                buttonPrev.Enabled = true;

                labelDishName.Text = dishes[dishes.Count - 1].DishName;

                dishStruct = await DishFromDb.DishStructureFromDb(dishes[dishes.Count - 1].Id);
                PrintDishStructure(dishStruct, dishes[dishes.Count - 1].DishName);

                receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[dishes.Count - 1].Id);
                if (receipt != null)
                {
                    richTextBoxReceipt.Text = receipt.Recipe_text;
                }
                else
                {
                    richTextBoxReceipt.Text = "Нет рецепта";
                }
            }
            else if (i < dishes.Count)
            {
                buttonNext.Enabled = true;
                buttonPrev.Enabled = true;
                i++;

                labelDishName.Text = dishes[i - 1].DishName;

                dishStruct = await DishFromDb.DishStructureFromDb(dishes[i - 1].Id);
                PrintDishStructure(dishStruct, dishes[i - 1].DishName);

                receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[i - 1].Id);
                if (receipt != null)
                {
                    richTextBoxReceipt.Text = receipt.Recipe_text;
                }
                else
                {
                    richTextBoxReceipt.Text = "Нет рецепта";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (receipt == null)
            {
                AddEditReceiptForm addEditReceiptForm = new AddEditReceiptForm(dishes[i - 1]);
                Hide();
                DialogResult result = addEditReceiptForm.ShowDialog();
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    Show();
                }
            }
            else
            {
                MessageBox.Show("У блюда уже есть рецепт");
            }
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (receipt != null)
            {
                AddEditReceiptForm addEditReceiptForm = new AddEditReceiptForm(dishes[i - 1], receipt);
                Hide();
                DialogResult result = addEditReceiptForm.ShowDialog();
                if (result == DialogResult.OK || result == DialogResult.Cancel)
                {
                    Show();
                }
            }
            else
            {
                MessageBox.Show("У блюда нет рецепта");
            }
        }

        private async void buttonDel_Click(object sender, EventArgs e)
        {
            string warning = "Вы действительно хотите удалить рецепт?";

            DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                await ReceiptFromDb.DeleteReceipt(receipt.Id);

                if (i >= dishes.Count)
                {
                    buttonNext.Enabled = true;
                    buttonPrev.Enabled = false;

                    i = 0;

                    labelDishName.Text = dishes[i].DishName;

                    dishStruct = await DishFromDb.DishStructureFromDb(dishes[i].Id);
                    PrintDishStructure(dishStruct, dishes[i].DishName);

                    receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[i].Id);
                    if (receipt != null)
                    {
                        richTextBoxReceipt.Text = receipt.Recipe_text;
                    }
                }
                else
                {
                    buttonNext.Enabled = true;
                    buttonPrev.Enabled = true;

                    labelDishName.Text = dishes[i].DishName;

                    dishStruct = await DishFromDb.DishStructureFromDb(dishes[i].Id);
                    PrintDishStructure(dishStruct, dishes[i].DishName);

                    receipt = await ReceiptFromDb.GetReceiptByDishId(dishes[i].Id);
                    if (receipt != null)
                    {
                        richTextBoxReceipt.Text = receipt.Recipe_text;
                    }
                }
            }
        }
    }
}
