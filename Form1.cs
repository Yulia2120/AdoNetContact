﻿using System;
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
            //SqlCommand command = new SqlCommand($"INSERT INTO [Address](UserId, Country, City, Street, House, Apartment ) VALUES (@UserId, @Country, @City, @Street, @House, @Apartment )", SqlConnection);

            //command.Parameters.AddWithValue("UserId", textBox7.Text);
            //command.Parameters.AddWithValue("Country", textBox8.Text);
            //command.Parameters.AddWithValue("City", textBox9.Text);
            //command.Parameters.AddWithValue("Street", textBox10.Text);
            //command.Parameters.AddWithValue("House", textBox11.Text);
            //command.Parameters.AddWithValue("Apartment ", textBox12.Text);
            //command.ExecuteNonQuery();
            //MessageBox.Show("Inserted");

        }

        private void butCarInsert_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand($"INSERT INTO [Car](UserId, Make, Model, RegNumber ) VALUES (@UserId, @Make, @Model, @RegNumber )", SqlConnection);
            //command.Parameters.AddWithValue("UserId", textBox13.Text);
            //command.Parameters.AddWithValue("Make", textBox14.Text);
            //command.Parameters.AddWithValue("Model", textBox16.Text);
            //command.Parameters.AddWithValue("RegNumber", textBox17.Text);
            //command.ExecuteNonQuery();
            //MessageBox.Show("Inserted");
        }

        private void butCompanyInsert_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand($"INSERT INTO [Company](UserId, CompanyName, Post) VALUES (@UserId, @CompanyName, @Post)", SqlConnection);
            //command.Parameters.AddWithValue("UserId", textBox18.Text);
            //command.Parameters.AddWithValue("CompanyName", textBox19.Text);
            //command.Parameters.AddWithValue("Post", textBox20.Text);
           // SqlCommand command = new SqlCommand($"UPDATE [Company] SET UserId = 8 WHERE Id = 8", SqlConnection);
            //command.ExecuteNonQuery();
            //MessageBox.Show("Inserted");
        }
    }
}
