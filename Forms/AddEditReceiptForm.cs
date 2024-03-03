using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kulinaria_app_v2.Classes;
using kulinaria_app_v2.Model;

namespace kulinaria_app_v2.Forms
{
    public partial class AddEditReceiptForm : Form
    {
        List<Dish> dishes = new List<Dish>();
        Dish currentDish;
        Receipt currReceipt;
        Receipt newReceipt;

        public AddEditReceiptForm(Dish dish)
        {
            InitializeComponent();
            currentDish = dish;
        }

        public AddEditReceiptForm(Dish dish, Receipt receipt)
        {
            InitializeComponent();
            currentDish = dish;
            currReceipt = receipt;
        }

        private async void AddEditReceiptForm_Load(object sender, EventArgs e)
        {
            labelDishName.Text = currentDish.DishName;

            if (currReceipt != null)
            {
                richTextBoxReceipt.Text = currReceipt.Recipe_text;
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {

            if (currReceipt != null)
            {
                newReceipt = new Receipt(currReceipt.Id, currentDish.Id, richTextBoxReceipt.Text);

                await ReceiptFromDb.UpdateReceipt(newReceipt);
            }
            else
            {
                newReceipt = new Receipt(0, currentDish.Id, richTextBoxReceipt.Text);

                await ReceiptFromDb.AddNewReceipt(newReceipt);
            }

            DialogResult = DialogResult.OK;
        }
    }
}
