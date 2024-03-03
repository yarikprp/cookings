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
using kulinaria_app_v2.Classes;

namespace kulinaria_app_v2.Forms
{
    public partial class PasswordChangeForm : Form
    {
        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private async void buttonChange_Click(object sender, EventArgs e)
        {
            if (textBoxOld.Text != "" && textBoxNew.Text != "" && textBoxPassRepeat.Text != "")
            {
                if (textBoxOld.Text != textBoxNew.Text)
                {
                    if (Verification.GetSHA512Hash(textBoxOld.Text) == AuthorisationForm.CurrentUser.Password)
                    {
                        if (UserFromDb.CheckPassword(textBoxNew.Text, textBoxPassRepeat.Text))
                        {
                            await UserFromDb.ChangePassword(AuthorisationForm.CurrentUser.UserId, textBoxNew.Text);

                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Проверьте пароль");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Проверьте поле старого пароля");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли совпадают");
                }
            }
            else
            {
                MessageBox.Show("Заполните поля");
            }
        }

        private void PasswordChangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
