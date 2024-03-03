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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxLogin.Text == ""
                || textBoxPassword.Text == "" || textBoxPasswordRepeat.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            else
            {
                if (await UserFromDb.CheckUser(textBoxLogin.Text) && UserFromDb.CheckPassword(textBoxPassword.Text, textBoxPasswordRepeat.Text))
                {
                    await UserFromDb.AddUser(textBoxLogin.Text, textBoxPassword.Text, textBoxFirstName.Text, textBoxLastName.Text);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private string GeneratePassword()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^";
            Random random = new Random();
            string password = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return password;
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            textBoxPassword.Text = password;
        }
    }
}
