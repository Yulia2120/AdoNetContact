using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoNetContact
{
    public partial class Form1 : Form
    {
        private SqlConnection SqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ContactDB"].ConnectionString);
            SqlConnection.Open();
            //if (SqlConnection != null)
            //{
            //    MessageBox.Show("Подключение установлено!");
            //}
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Users](FirstName, Surname, LastName, Birthday, Phone, DataAdded) VALUES (@FirstName, @Surname, @LastName, @Birthday, @Phone, @DataAdded)", SqlConnection);

            command.Parameters.AddWithValue("FirstName", textBox1.Text);
            command.Parameters.AddWithValue("Surname", textBox2.Text);
            command.Parameters.AddWithValue("LastName", textBox3.Text);
            command.Parameters.AddWithValue("Birthday", textBox4.Text);
            command.Parameters.AddWithValue("Phone", textBox5.Text);
            command.Parameters.AddWithValue("DataAdded", textBox6.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");

        }

        private void butInsertAddress_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Address](UserId, Country, City, Street, House, Apartment ) VALUES (@UserId, @Country, @City, @Street, @House, @Apartment )", SqlConnection);

            command.Parameters.AddWithValue("UserId", textBox7.Text);
            command.Parameters.AddWithValue("Country", textBox8.Text);
            command.Parameters.AddWithValue("City", textBox9.Text);
            command.Parameters.AddWithValue("Street", textBox10.Text);
            command.Parameters.AddWithValue("House", textBox11.Text);
            command.Parameters.AddWithValue("Apartment ", textBox12.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");

        }

        private void butCarInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Car](UserId, Make, Model, RegNumber ) VALUES (@UserId, @Make, @Model, @RegNumber )", SqlConnection);
            command.Parameters.AddWithValue("UserId", textBox13.Text);
            command.Parameters.AddWithValue("Make", textBox14.Text);
            command.Parameters.AddWithValue("Model", textBox16.Text);
            command.Parameters.AddWithValue("RegNumber", textBox17.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");
        }

        private void butCompanyInsert_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Company](UserId, CompanyName, Post) VALUES (@UserId, @CompanyName, @Post)", SqlConnection);
            command.Parameters.AddWithValue("UserId", textBox18.Text);
            command.Parameters.AddWithValue("CompanyName", textBox19.Text);
            command.Parameters.AddWithValue("Post", textBox20.Text);
            //SqlCommand command = new SqlCommand($"UPDATE [Company] SET UserId = 8 WHERE Id = 8", SqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");
        }

        private void butGridViewFindAll_Click(object sender, EventArgs e)
        {
            string query = "SELECT U.*, A.Country as Country, A.City as City, A.Street as Street, A.House as House, A.Apartment as Apartment, C.Make as Make, C.Model as Model, C.RegNumber as RegNumber, Co.CompanyName as CompanyName, Co.Post as Post FROM Users as U JOIN Address as A ON UserId = U.Id JOIN Car as C ON C.UserId = U.Id JOIN Company as Co ON Co.UserId = U.Id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, SqlConnection);
            DataSet db = new DataSet();
            adapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
        }

        private void butUsersDel_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"DELETE FROM [Users] WHERE Id = 13", SqlConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted");
        }

        private void textBoxSortFN_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"FirstName LIKE '%{textBoxSortFN.Text}%'";
        }

        private void textBoxSortSN_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Surname LIKE '%{textBoxSortSN.Text}%'";
        }

        private void textBoxSortLN_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"LastName LIKE '%{textBoxSortLN.Text}%'";
        }

        private void textBoxSortMO_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Phone LIKE '%{textBoxSortMO.Text}%'";
        }

        private void textBoxSortData_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"DataAdded LIKE '%{textBoxSortData.Text}%'";
        }

        private void butContactList_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, SqlConnection);
            DataSet db = new DataSet();
            adapter.Fill(db);
            dataGridView2.DataSource = db.Tables[0];
        }
        //SqlConnection.Close();
    }

}
