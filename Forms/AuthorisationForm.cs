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
    public partial class AuthorisationForm : Form
    {
        public static User CurrentUser { get; set; } = null;
        private int loginButtonClickCount = 0;

        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }
            else
            {
                if (loginButtonClickCount == 1)
                {
                    ShowCaptchaForm();
                }
                else
                {
                    CurrentUser = await UserFromDb.GetUser(textBoxLogin.Text, textBoxPassword.Text);

                    if (CurrentUser != null)
                    {
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Такого пользователя не существует");
                        loginButtonClickCount++;
                    }
                }
            }
        }
        private void ShowCaptchaForm()
        {
            CaptchaForm captchaForm = new CaptchaForm();
            captchaForm.ShowDialog(); // Показываем форму каптчи модально
            loginButtonClickCount = 0; // Сбрасываем счетчик нажатий кнопки входа
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regisrationForm = new RegistrationForm();
            Hide();

            DialogResult res = regisrationForm.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Cancel)
            {
                Show();
            }
        }
    }
}
