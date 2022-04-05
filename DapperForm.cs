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
            operation = UsersEnumClass.Add;
            ClearControls();
            EnableControls(true);
            butAdd.Enabled = false;
            butEdit.Enabled = false;
            usersBindingSource.Add(new Users());
            usersBindingSource.MoveLast();
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            operation = UsersEnumClass.Edit;
            EnableControls(true);
            butAdd.Enabled = false;
            butEdit.Enabled = false;
          
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            operation = UsersEnumClass.Cansel;
            ClearControls();
            EnableControls(false);
            butAdd.Enabled = true;
            butEdit.Enabled = true;
            usersBindingSource.ResetBindings(false);
            usersBindingSource.DataSource = GetUsersClassData.GetUsers();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            try
            {
                Users obj = usersBindingSource.Current as Users;
                if (obj != null)
                {
                    if (operation == UsersEnumClass.Add)
                    {
                        GetUsersClassData.Insert(obj);
                        MessageBox.Show("Inserted");
                    }
                    else if (operation == UsersEnumClass.Edit)
                    {
                        GetUsersClassData.Update(obj);
                        MessageBox.Show("Updated");
                    }

                    operation = UsersEnumClass.Cansel;
                    ClearControls();
                    EnableControls(false);
                    butAdd.Enabled = true;
                    butEdit.Enabled = true;
                    usersBindingSource.ResetBindings(false);
                    usersBindingSource.DataSource = GetUsersClassData.GetUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Users obj = usersBindingSource.Current as Users;
                if (obj != null)
                {
                    GetUsersClassData.Delete(obj);
                    MessageBox.Show("Deleted");
                    operation = UsersEnumClass.Cansel;
                    ClearControls();
                    EnableControls(false);
                    butAdd.Enabled = true;
                    butEdit.Enabled = true;
                    usersBindingSource.ResetBindings(false);
                    usersBindingSource.DataSource = GetUsersClassData.GetUsers();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
