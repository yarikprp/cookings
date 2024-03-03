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
    public partial class ProfileEditForm : Form
    {
        public ProfileEditForm()
        {
            InitializeComponent();
        }

        private void ProfileEditForm_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = AuthorisationForm.CurrentUser.FirstName;
            textBoxLastName.Text = AuthorisationForm.CurrentUser.LastName;
            textBoxPatronymic.Text = AuthorisationForm.CurrentUser.Patronymic;
            dateTimePickerBirthDay.Value = AuthorisationForm.CurrentUser.DateOfBirthday;
            textBoxPhone.Text = AuthorisationForm.CurrentUser.Phone;
            textBoxAdress.Text = AuthorisationForm.CurrentUser.Adress;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "")
            {
                AuthorisationForm.CurrentUser.FirstName = textBoxFirstName.Text;
                AuthorisationForm.CurrentUser.LastName = textBoxLastName.Text;
                AuthorisationForm.CurrentUser.Patronymic = textBoxPatronymic.Text;
                AuthorisationForm.CurrentUser.DateOfBirthday = dateTimePickerBirthDay.Value;
                AuthorisationForm.CurrentUser.Phone = textBoxPhone.Text;
                AuthorisationForm.CurrentUser.Adress = textBoxAdress.Text;

                await UserFromDb.UpdateUserProfile(AuthorisationForm.CurrentUser);

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
