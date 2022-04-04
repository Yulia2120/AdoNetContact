using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdoNetContact
{
    public partial class DapperForm : Form
    {
        public DapperForm()
        {
            InitializeComponent();
           usersBindingSource.DataSource = GetUsersClassData.GetUsers();
        }

        void ClearControls()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtSurName.Clear();
            txtLastName.Clear();
            txtBirthday.Clear();
            txtPhone.Clear();
            txtData.Clear();

        }
        void EnableControls(bool value)
        {
            txtId.Enabled = value;
            txtFirstName.Enabled = value;
            txtSurName.Enabled = value;
            txtLastName.Enabled = value;
            txtBirthday.Enabled = value;
            txtPhone.Enabled = value;
            txtData.Enabled = value;
            butSave.Enabled = value;
            butDelete.Enabled = value;
        }
        UsersEnumClass operation = UsersEnumClass.Add;
        private void butAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
