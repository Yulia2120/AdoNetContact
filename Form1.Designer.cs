namespace AdoNetContact
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
            this.butUsersUpdate = new System.Windows.Forms.Button();
            this.butUsersDel = new System.Windows.Forms.Button();
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
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.butCarInsert = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.tabCompany = new System.Windows.Forms.TabPage();
            this.butCompanyInsert = new System.Windows.Forms.Button();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.tabAllInfo = new System.Windows.Forms.TabPage();
            this.textBoxSortSN = new System.Windows.Forms.TextBox();
            this.labelSortSN = new System.Windows.Forms.Label();
            this.labelSortFN = new System.Windows.Forms.Label();
            this.textBoxSortFN = new System.Windows.Forms.TextBox();
            this.butGridViewFindAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSortLN = new System.Windows.Forms.Label();
            this.textBoxSortLN = new System.Windows.Forms.TextBox();
            this.labelSortMO = new System.Windows.Forms.Label();
            this.textBoxSortMO = new System.Windows.Forms.TextBox();
            this.labelSortData = new System.Windows.Forms.Label();
            this.textBoxSortData = new System.Windows.Forms.TextBox();
            this.tabCont = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.butContactList = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.tabAddress.SuspendLayout();
            this.tabCar.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.tabAllInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabCont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabUsers);
            this.tabControl.Controls.Add(this.tabAddress);
            this.tabControl.Controls.Add(this.tabCar);
            this.tabControl.Controls.Add(this.tabCompany);
            this.tabControl.Controls.Add(this.tabAllInfo);
            this.tabControl.Controls.Add(this.tabCont);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 642);
            this.tabControl.TabIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.butUsersUpdate);
            this.tabUsers.Controls.Add(this.butUsersDel);
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
            this.tabUsers.Size = new System.Drawing.Size(767, 616);
            this.tabUsers.TabIndex = 0;
            this.tabUsers.Text = "Users";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // butUsersUpdate
            // 
            this.butUsersUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butUsersUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUsersUpdate.Location = new System.Drawing.Point(665, 110);
            this.butUsersUpdate.Name = "butUsersUpdate";
            this.butUsersUpdate.Size = new System.Drawing.Size(94, 23);
            this.butUsersUpdate.TabIndex = 3;
            this.butUsersUpdate.Text = "UPDATE";
            this.butUsersUpdate.UseVisualStyleBackColor = false;
            this.butUsersUpdate.Click += new System.EventHandler(this.butUsersUpdate_Click);
            // 
            // butUsersDel
            // 
            this.butUsersDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butUsersDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butUsersDel.Location = new System.Drawing.Point(665, 71);
            this.butUsersDel.Name = "butUsersDel";
            this.butUsersDel.Size = new System.Drawing.Size(94, 23);
            this.butUsersDel.TabIndex = 2;
            this.butUsersDel.Text = "DELETE";
            this.butUsersDel.UseVisualStyleBackColor = false;
            this.butUsersDel.Click += new System.EventHandler(this.butUsersDel_Click);
            // 
            // butInsert
            // 
            this.butInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.tabAddress.Size = new System.Drawing.Size(767, 616);
            this.tabAddress.TabIndex = 1;
            this.tabAddress.Text = "Address";
            this.tabAddress.UseVisualStyleBackColor = true;
            // 
            // butInsertAddress
            // 
            this.butInsertAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butInsertAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.tabCar.Size = new System.Drawing.Size(767, 616);
            this.tabCar.TabIndex = 2;
            this.tabCar.Text = "Car";
            this.tabCar.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(385, 51);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 2;
            // 
            // butCarInsert
            // 
            this.butCarInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butCarInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCarInsert.Location = new System.Drawing.Point(547, 51);
            this.butCarInsert.Name = "butCarInsert";
            this.butCarInsert.Size = new System.Drawing.Size(101, 23);
            this.butCarInsert.TabIndex = 1;
            this.butCarInsert.Text = "INSERT";
            this.butCarInsert.UseVisualStyleBackColor = false;
            this.butCarInsert.Click += new System.EventHandler(this.butCarInsert_Click);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(267, 51);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(104, 20);
            this.textBox16.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(267, 51);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 0;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(157, 51);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 0;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(43, 51);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 0;
            // 
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.butCompanyInsert);
            this.tabCompany.Controls.Add(this.textBox20);
            this.tabCompany.Controls.Add(this.textBox19);
            this.tabCompany.Controls.Add(this.textBox18);
            this.tabCompany.Location = new System.Drawing.Point(4, 22);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.Size = new System.Drawing.Size(767, 616);
            this.tabCompany.TabIndex = 3;
            this.tabCompany.Text = "Company";
            this.tabCompany.UseVisualStyleBackColor = true;
            // 
            // butCompanyInsert
            // 
            this.butCompanyInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butCompanyInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCompanyInsert.Location = new System.Drawing.Point(490, 44);
            this.butCompanyInsert.Name = "butCompanyInsert";
            this.butCompanyInsert.Size = new System.Drawing.Size(99, 23);
            this.butCompanyInsert.TabIndex = 1;
            this.butCompanyInsert.Text = "INSERT";
            this.butCompanyInsert.UseVisualStyleBackColor = false;
            this.butCompanyInsert.Click += new System.EventHandler(this.butCompanyInsert_Click);
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(265, 44);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 20);
            this.textBox20.TabIndex = 0;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(154, 44);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 0;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(43, 44);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 0;
            // 
            // tabAllInfo
            // 
            this.tabAllInfo.Controls.Add(this.textBoxSortData);
            this.tabAllInfo.Controls.Add(this.labelSortData);
            this.tabAllInfo.Controls.Add(this.textBoxSortMO);
            this.tabAllInfo.Controls.Add(this.labelSortMO);
            this.tabAllInfo.Controls.Add(this.textBoxSortLN);
            this.tabAllInfo.Controls.Add(this.labelSortLN);
            this.tabAllInfo.Controls.Add(this.textBoxSortSN);
            this.tabAllInfo.Controls.Add(this.labelSortSN);
            this.tabAllInfo.Controls.Add(this.labelSortFN);
            this.tabAllInfo.Controls.Add(this.textBoxSortFN);
            this.tabAllInfo.Controls.Add(this.butGridViewFindAll);
            this.tabAllInfo.Controls.Add(this.dataGridView1);
            this.tabAllInfo.Location = new System.Drawing.Point(4, 22);
            this.tabAllInfo.Name = "tabAllInfo";
            this.tabAllInfo.Size = new System.Drawing.Size(767, 616);
            this.tabAllInfo.TabIndex = 4;
            this.tabAllInfo.Text = "AllInfo";
            this.tabAllInfo.UseVisualStyleBackColor = true;
            // 
            // textBoxSortSN
            // 
            this.textBoxSortSN.Location = new System.Drawing.Point(301, 395);
            this.textBoxSortSN.Name = "textBoxSortSN";
            this.textBoxSortSN.Size = new System.Drawing.Size(348, 20);
            this.textBoxSortSN.TabIndex = 5;
            this.textBoxSortSN.TextChanged += new System.EventHandler(this.textBoxSortSN_TextChanged);
            // 
            // labelSortSN
            // 
            this.labelSortSN.AutoSize = true;
            this.labelSortSN.Location = new System.Drawing.Point(144, 400);
            this.labelSortSN.Name = "labelSortSN";
            this.labelSortSN.Size = new System.Drawing.Size(113, 13);
            this.labelSortSN.TabIndex = 4;
            this.labelSortSN.Text = "SortAndFind_Surname";
            // 
            // labelSortFN
            // 
            this.labelSortFN.AutoSize = true;
            this.labelSortFN.Location = new System.Drawing.Point(144, 369);
            this.labelSortFN.Name = "labelSortFN";
            this.labelSortFN.Size = new System.Drawing.Size(118, 13);
            this.labelSortFN.TabIndex = 3;
            this.labelSortFN.Text = "SortAndFind_FirstName";
            // 
            // textBoxSortFN
            // 
            this.textBoxSortFN.Location = new System.Drawing.Point(301, 362);
            this.textBoxSortFN.Name = "textBoxSortFN";
            this.textBoxSortFN.Size = new System.Drawing.Size(348, 20);
            this.textBoxSortFN.TabIndex = 2;
            this.textBoxSortFN.TextChanged += new System.EventHandler(this.textBoxSortFN_TextChanged);
            // 
            // butGridViewFindAll
            // 
            this.butGridViewFindAll.BackColor = System.Drawing.Color.Red;
            this.butGridViewFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butGridViewFindAll.ForeColor = System.Drawing.Color.White;
            this.butGridViewFindAll.Location = new System.Drawing.Point(649, 316);
            this.butGridViewFindAll.Name = "butGridViewFindAll";
            this.butGridViewFindAll.Size = new System.Drawing.Size(75, 23);
            this.butGridViewFindAll.TabIndex = 1;
            this.butGridViewFindAll.Text = "FINDALL";
            this.butGridViewFindAll.UseVisualStyleBackColor = false;
            this.butGridViewFindAll.Click += new System.EventHandler(this.butGridViewFindAll_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 284);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelSortLN
            // 
            this.labelSortLN.AutoSize = true;
            this.labelSortLN.Location = new System.Drawing.Point(144, 431);
            this.labelSortLN.Name = "labelSortLN";
            this.labelSortLN.Size = new System.Drawing.Size(119, 13);
            this.labelSortLN.TabIndex = 6;
            this.labelSortLN.Text = "SortAndFind_LastName";
            // 
            // textBoxSortLN
            // 
            this.textBoxSortLN.Location = new System.Drawing.Point(301, 428);
            this.textBoxSortLN.Name = "textBoxSortLN";
            this.textBoxSortLN.Size = new System.Drawing.Size(348, 20);
            this.textBoxSortLN.TabIndex = 7;
            this.textBoxSortLN.TextChanged += new System.EventHandler(this.textBoxSortLN_TextChanged);
            // 
            // labelSortMO
            // 
            this.labelSortMO.AutoSize = true;
            this.labelSortMO.Location = new System.Drawing.Point(144, 462);
            this.labelSortMO.Name = "labelSortMO";
            this.labelSortMO.Size = new System.Drawing.Size(143, 13);
            this.labelSortMO.TabIndex = 8;
            this.labelSortMO.Text = "SortAndFind_MobileOperator";
            // 
            // textBoxSortMO
            // 
            this.textBoxSortMO.Location = new System.Drawing.Point(301, 461);
            this.textBoxSortMO.Name = "textBoxSortMO";
            this.textBoxSortMO.Size = new System.Drawing.Size(348, 20);
            this.textBoxSortMO.TabIndex = 9;
            this.textBoxSortMO.TextChanged += new System.EventHandler(this.textBoxSortMO_TextChanged);
            // 
            // labelSortData
            // 
            this.labelSortData.AutoSize = true;
            this.labelSortData.Location = new System.Drawing.Point(144, 493);
            this.labelSortData.Name = "labelSortData";
            this.labelSortData.Size = new System.Drawing.Size(125, 13);
            this.labelSortData.TabIndex = 10;
            this.labelSortData.Text = "SortAndFind_DataAdded";
            // 
            // textBoxSortData
            // 
            this.textBoxSortData.Location = new System.Drawing.Point(301, 494);
            this.textBoxSortData.Name = "textBoxSortData";
            this.textBoxSortData.Size = new System.Drawing.Size(348, 20);
            this.textBoxSortData.TabIndex = 11;
            this.textBoxSortData.TextChanged += new System.EventHandler(this.textBoxSortData_TextChanged);
            // 
            // tabCont
            // 
            this.tabCont.Controls.Add(this.butContactList);
            this.tabCont.Controls.Add(this.dataGridView2);
            this.tabCont.Location = new System.Drawing.Point(4, 22);
            this.tabCont.Name = "tabCont";
            this.tabCont.Size = new System.Drawing.Size(767, 616);
            this.tabCont.TabIndex = 5;
            this.tabCont.Text = "Contacts";
            this.tabCont.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(767, 291);
            this.dataGridView2.TabIndex = 0;
            // 
            // butContactList
            // 
            this.butContactList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.butContactList.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butContactList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butContactList.Location = new System.Drawing.Point(655, 352);
            this.butContactList.Name = "butContactList";
            this.butContactList.Size = new System.Drawing.Size(75, 23);
            this.butContactList.TabIndex = 1;
            this.butContactList.Text = "ContactList";
            this.butContactList.UseVisualStyleBackColor = false;
            this.butContactList.Click += new System.EventHandler(this.butContactList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 642);
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
            this.tabAllInfo.ResumeLayout(false);
            this.tabAllInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabCont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.TabPage tabAllInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butGridViewFindAll;
        private System.Windows.Forms.Button butUsersDel;
        private System.Windows.Forms.Button butUsersUpdate;
        private System.Windows.Forms.Label labelSortFN;
        private System.Windows.Forms.TextBox textBoxSortFN;
        private System.Windows.Forms.TextBox textBoxSortSN;
        private System.Windows.Forms.Label labelSortSN;
        private System.Windows.Forms.TextBox textBoxSortLN;
        private System.Windows.Forms.Label labelSortLN;
        private System.Windows.Forms.TextBox textBoxSortMO;
        private System.Windows.Forms.Label labelSortMO;
        private System.Windows.Forms.TextBox textBoxSortData;
        private System.Windows.Forms.Label labelSortData;
        private System.Windows.Forms.TabPage tabCont;
        private System.Windows.Forms.Button butContactList;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

