﻿namespace AdoNetContact
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.butInsert = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabAddress = new System.Windows.Forms.TabPage();
            this.butInsertAddress = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tabCar = new System.Windows.Forms.TabPage();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.butCarInsert = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.butCompanyInsert = new System.Windows.Forms.Button();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabAddress.SuspendLayout();
            this.tabCar.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.tabContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabAddress);
            this.tabControl.Controls.Add(this.tabCar);
            this.tabControl.Controls.Add(this.tabCompany);
            this.tabControl.Controls.Add(this.tabContacts);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.butInsert);
            this.tabUsers.Controls.Add(this.textBox6);
            this.tabUsers.Controls.Add(this.textBox5);
            this.tabUsers.Controls.Add(this.textBox4);
            this.tabUsers.Controls.Add(this.textBox3);
            this.tabUsers.Controls.Add(this.textBox2);
            this.tabUsers.Controls.Add(this.textBox1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(767, 424);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // butInsert
            // 
            this.butInsert.BackColor = System.Drawing.Color.MistyRose;
            this.butInsert.Location = new System.Drawing.Point(665, 32);
            this.butInsert.Name = "butInsert";
            this.butInsert.Size = new System.Drawing.Size(94, 23);
            this.butInsert.TabIndex = 1;
            this.butInsert.Text = "INSERT";
            this.butInsert.UseVisualStyleBackColor = false;
            this.butInsert.Click += new System.EventHandler(this.butInsert_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(548, 35);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(440, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(332, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(224, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabAddress
            // 
            this.tabAddress.Controls.Add(this.butInsertAddress);
            this.tabAddress.Controls.Add(this.textBox12);
            this.tabAddress.Controls.Add(this.textBox11);
            this.tabAddress.Controls.Add(this.textBox10);
            this.tabAddress.Controls.Add(this.textBox9);
            this.tabAddress.Controls.Add(this.textBox8);
            this.tabAddress.Controls.Add(this.textBox7);
            this.tabAddress.Location = new System.Drawing.Point(4, 22);
            this.tabAddress.Name = "tabAddress";
            this.tabAddress.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddress.Size = new System.Drawing.Size(767, 424);
            this.tabAddress.TabIndex = 1;
            this.tabAddress.Text = "Address";
            this.tabAddress.UseVisualStyleBackColor = true;
            // 
            // butInsertAddress
            // 
            this.butInsertAddress.BackColor = System.Drawing.Color.Red;
            this.butInsertAddress.Location = new System.Drawing.Point(665, 32);
            this.butInsertAddress.Name = "butInsertAddress";
            this.butInsertAddress.Size = new System.Drawing.Size(94, 23);
            this.butInsertAddress.TabIndex = 1;
            this.butInsertAddress.Text = "INSERT";
            this.butInsertAddress.UseVisualStyleBackColor = false;
            this.butInsertAddress.Click += new System.EventHandler(this.butInsertAddress_Click);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(550, 34);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 0;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(444, 34);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(338, 34);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 0;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(232, 34);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 0;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(126, 34);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(20, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 0;
            // 
            // tabCar
            // 
            this.tabCar.Controls.Add(this.textBox17);
            this.tabCar.Controls.Add(this.butCarInsert);
            this.tabCar.Controls.Add(this.textBox16);
            this.tabCar.Controls.Add(this.textBox15);
            this.tabCar.Controls.Add(this.textBox14);
            this.tabCar.Controls.Add(this.textBox13);
            this.tabCar.Location = new System.Drawing.Point(4, 22);
            this.tabCar.Name = "tabCar";
            this.tabCar.Size = new System.Drawing.Size(767, 424);
            this.tabCar.TabIndex = 2;
            this.tabCar.Text = "Car";
            this.tabCar.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(43, 51);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 0;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(157, 51);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(267, 51);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 0;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(267, 51);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(104, 20);
            this.textBox16.TabIndex = 0;
            // 
            // butCarInsert
            // 
            this.butCarInsert.Location = new System.Drawing.Point(547, 51);
            this.butCarInsert.Name = "butCarInsert";
            this.butCarInsert.Size = new System.Drawing.Size(101, 23);
            this.butCarInsert.TabIndex = 1;
            this.butCarInsert.Text = "Insert";
            this.butCarInsert.UseVisualStyleBackColor = true;
            this.butCarInsert.Click += new System.EventHandler(this.butCarInsert_Click);
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(385, 51);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 2;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.butCompanyInsert);
            this.tabCompany.Controls.Add(this.textBox20);
            this.tabCompany.Controls.Add(this.textBox19);
            this.tabCompany.Controls.Add(this.textBox18);
            this.tabCompany.Location = new System.Drawing.Point(4, 22);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Size = new System.Drawing.Size(767, 424);
            this.tabCompany.TabIndex = 3;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(43, 44);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 0;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(154, 44);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 0;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(265, 44);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 0;
            // 
            // butCompanyInsert
            // 
            this.butCompanyInsert.Location = new System.Drawing.Point(490, 44);
            this.butCompanyInsert.Name = "butCompanyInsert";
            this.butCompanyInsert.Size = new System.Drawing.Size(99, 23);
            this.butCompanyInsert.TabIndex = 1;
            this.butCompanyInsert.Text = "Insert";
            this.butCompanyInsert.UseVisualStyleBackColor = true;
            this.butCompanyInsert.Click += new System.EventHandler(this.butCompanyInsert_Click);
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.dataGridView1);
            this.tabContacts.Location = new System.Drawing.Point(4, 22);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Size = new System.Drawing.Size(767, 424);
            this.tabContacts.TabIndex = 4;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.tabAddress.ResumeLayout(false);
            this.tabAddress.PerformLayout();
            this.tabCar.ResumeLayout(false);
            this.tabCar.PerformLayout();
            this.tabCompany.ResumeLayout(false);
            this.tabCompany.PerformLayout();
            this.tabContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabAddress;
        private System.Windows.Forms.Button butInsert;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button butInsertAddress;
        private System.Windows.Forms.TabPage tabCar;
        private System.Windows.Forms.Button butCarInsert;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TabPage tabCompany;
        private System.Windows.Forms.Button butCompanyInsert;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

