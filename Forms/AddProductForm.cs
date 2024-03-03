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
    public partial class AddProductForm : Form
    {
        public int whereIsCalled;

        public AddProductForm(int whereIsCalled)
        {
            InitializeComponent();
            this.whereIsCalled = whereIsCalled;
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && numericUpDownProt.Value > -1 && numericUpDownFats.Value > -1 && numericUpDownCarboh.Value > -1)
            {
                await ProductsFromDb.AddProduct(textBoxName.Text, (int)numericUpDownProt.Value, (int)numericUpDownFats.Value, (int)numericUpDownCarboh.Value);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }
    }
}
