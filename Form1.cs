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
            //if(SqlConnection != null)
            //{
            //    MessageBox.Show("Подключение установлено!");
            //}
        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand($"DELETE FROM [Users] WHERE Id = 11", SqlConnection); //(FirstName, Surname, LastName, Birthday, Phone, DataAdded) VALUES (@FirstName, @Surname, @LastName, @Birthday, @Phone, @DataAdded)", SqlConnection);
     
            //command.Parameters.AddWithValue("FirstName", textBox1.Text);
            //command.Parameters.AddWithValue("Surname", textBox2.Text);
            //command.Parameters.AddWithValue("LastName", textBox3.Text);
            //command.Parameters.AddWithValue("Birthday", textBox4.Text);
            //command.Parameters.AddWithValue("Phone", textBox5.Text);
            //command.Parameters.AddWithValue("DataAdded", textBox6.Text);
           // command.ExecuteNonQuery();
           // MessageBox.Show("Inserted");

        }
       
        private void butInsertAddress_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [Address](UserId, Country, City, Street, House, Apartment ) VALUES (@UserId, @Country, @City, @Street, @House, @Apartment )", SqlConnection);

            command.Parameters.AddWithValue("UserId", textBox1.Text);
            command.Parameters.AddWithValue("Country", textBox2.Text);
            command.Parameters.AddWithValue("City", textBox3.Text);
            command.Parameters.AddWithValue("Street", textBox4.Text);
            command.Parameters.AddWithValue("House", textBox5.Text);
            command.Parameters.AddWithValue("Apartment ", textBox6.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Inserted");

        }
    }
}
