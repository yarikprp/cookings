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
    public partial class UsersControlForm : Form
    {
        List<User> users = new List<User>();
        int selectedIndex;

        public UsersControlForm()
        {
            InitializeComponent();
            dataGridViewUsers.Columns[0].DataPropertyName = "UserId";
            dataGridViewUsers.Columns[1].DataPropertyName = "FirstName";
            dataGridViewUsers.Columns[2].DataPropertyName = "Patronymic";
            dataGridViewUsers.Columns[3].DataPropertyName = "LastName";
            dataGridViewUsers.Columns[4].DataPropertyName = "RoleId";
            dataGridViewUsers.Columns[5].DataPropertyName = "DateOfBirthday";
            dataGridViewUsers.Columns[6].DataPropertyName = "Login";
            dataGridViewUsers.Columns[7].DataPropertyName = "Password";
            dataGridViewUsers.Columns[8].DataPropertyName = "Phone";
            dataGridViewUsers.Columns[9].DataPropertyName = "Adress";

            dataGridViewUsers.Columns[0].Visible = false;
            dataGridViewUsers.Columns[4].Visible = false;
            dataGridViewUsers.Columns[5].Visible = false;
            dataGridViewUsers.Columns[6].Visible = false;
            dataGridViewUsers.Columns[7].Visible = false;
            dataGridViewUsers.Columns[8].Visible = false;
            dataGridViewUsers.Columns[9].Visible = false;

            comboBoxRoles.DisplayMember = "Name";
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            Hide();

            DialogResult res = registrationForm.ShowDialog();
            if (res == DialogResult.OK || res == DialogResult.Cancel)
            {
                Show();
            }

            users = await UserFromDb.GetUsers();
            dataGridViewUsers.DataSource = users;
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            string warning = "Вы действительно хотите удалить пользователя " + users[selectedIndex].FirstName + " " + users[selectedIndex].LastName + "?";

            DialogResult result = MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (users[selectedIndex].UserId != AuthorisationForm.CurrentUser.UserId)
                {
                    await UserFromDb.DeleteUser(users[selectedIndex]);

                    users = await UserFromDb.GetUsers();
                    dataGridViewUsers.DataSource = users;
                }
                else
                {
                    MessageBox.Show("Извините, но вы не можете удалить себя, пока находитесь в системе");
                }
            }
        }

        private async void buttonChangeRole_Click(object sender, EventArgs e)
        {
            await UserFromDb.ChangeRole(users[selectedIndex], comboBoxRoles.SelectedIndex + 1);

            users = await UserFromDb.GetUsers();
            dataGridViewUsers.DataSource = users;
        }

        private async void UsersControlForm_Load(object sender, EventArgs e)
        {
            users = await UserFromDb.GetUsers();
            dataGridViewUsers.DataSource = users;
            comboBoxRoles.DataSource = await RoleFromDb.GetRoles();
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridViewUsers.CurrentCell.RowIndex;

            textBoxFirstName.Text = users[selectedIndex].FirstName;
            textBoxLastName.Text = users[selectedIndex].LastName;
            textBoxPatronymic.Text = users[selectedIndex].Patronymic;
            dateTimePickerBirthday.Value = users[selectedIndex].DateOfBirthday;
            textBoxPhone.Text = users[selectedIndex].Phone;
            textBoxAdress.Text = users[selectedIndex].Adress;
            comboBoxRoles.SelectedIndex = users[selectedIndex].RoleId - 1;
        }

        private void UsersControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
