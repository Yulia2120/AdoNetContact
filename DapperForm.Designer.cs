namespace AdoNetContact
{
    partial class DapperForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtId = new System.Windows.Forms.TextBox();
            this.labId = new System.Windows.Forms.Label();
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butSave = new System.Windows.Forms.Button();
            this.butDelete = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labFN = new System.Windows.Forms.Label();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.labSN = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labLN = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.labBirthday = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.labData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.surNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dataAddedDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.usersBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.Color.Silver;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(744, 689);
            this.dataGridView.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.butDelete);
            this.panel.Controls.Add(this.butSave);
            this.panel.Controls.Add(this.butCancel);
            this.panel.Controls.Add(this.butEdit);
            this.panel.Controls.Add(this.butAdd);
            this.panel.Controls.Add(this.labData);
            this.panel.Controls.Add(this.labPhone);
            this.panel.Controls.Add(this.labBirthday);
            this.panel.Controls.Add(this.labLN);
            this.panel.Controls.Add(this.labSN);
            this.panel.Controls.Add(this.labFN);
            this.panel.Controls.Add(this.labId);
            this.panel.Controls.Add(this.txtData);
            this.panel.Controls.Add(this.txtPhone);
            this.panel.Controls.Add(this.txtBirthday);
            this.panel.Controls.Add(this.txtLastName);
            this.panel.Controls.Add(this.txtSurName);
            this.panel.Controls.Add(this.txtFirstName);
            this.panel.Controls.Add(this.txtId);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 325);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(744, 364);
            this.panel.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surNameDataGridViewTextBoxColumn
            // 
            this.surNameDataGridViewTextBoxColumn.DataPropertyName = "SurName";
            this.surNameDataGridViewTextBoxColumn.HeaderText = "SurName";
            this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
            this.surNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataAddedDataGridViewTextBoxColumn
            // 
            this.dataAddedDataGridViewTextBoxColumn.DataPropertyName = "DataAdded";
            this.dataAddedDataGridViewTextBoxColumn.HeaderText = "DataAdded";
            this.dataAddedDataGridViewTextBoxColumn.Name = "dataAddedDataGridViewTextBoxColumn";
            this.dataAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(AdoNetContact.Users);
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtId.Location = new System.Drawing.Point(142, 89);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 27);
            this.txtId.TabIndex = 1;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labId.Location = new System.Drawing.Point(33, 92);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(22, 20);
            this.labId.TabIndex = 2;
            this.labId.Text = "Id";
            // 
            // butAdd
            // 
            this.butAdd.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAdd.Location = new System.Drawing.Point(37, 23);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(124, 34);
            this.butAdd.TabIndex = 3;
            this.butAdd.Text = "Add";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEdit.Location = new System.Drawing.Point(189, 23);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(124, 34);
            this.butEdit.TabIndex = 3;
            this.butEdit.Text = "Edit";
            this.butEdit.UseVisualStyleBackColor = true;
            // 
            // butCancel
            // 
            this.butCancel.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCancel.Location = new System.Drawing.Point(331, 23);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(124, 34);
            this.butCancel.TabIndex = 3;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            // 
            // butSave
            // 
            this.butSave.Enabled = false;
            this.butSave.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butSave.Location = new System.Drawing.Point(448, 309);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(124, 34);
            this.butSave.TabIndex = 3;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            // 
            // butDelete
            // 
            this.butDelete.Enabled = false;
            this.butDelete.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelete.Location = new System.Drawing.Point(595, 309);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(124, 34);
            this.butDelete.TabIndex = 3;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "FirstName", true));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFirstName.Location = new System.Drawing.Point(142, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(203, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // labFN
            // 
            this.labFN.AutoSize = true;
            this.labFN.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labFN.Location = new System.Drawing.Point(33, 125);
            this.labFN.Name = "labFN";
            this.labFN.Size = new System.Drawing.Size(76, 20);
            this.labFN.TabIndex = 2;
            this.labFN.Text = "FirstName";
            // 
            // txtSurName
            // 
            this.txtSurName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "SurName", true));
            this.txtSurName.Enabled = false;
            this.txtSurName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSurName.Location = new System.Drawing.Point(142, 155);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(203, 27);
            this.txtSurName.TabIndex = 1;
            // 
            // labSN
            // 
            this.labSN.AutoSize = true;
            this.labSN.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSN.Location = new System.Drawing.Point(33, 158);
            this.labSN.Name = "labSN";
            this.labSN.Size = new System.Drawing.Size(70, 20);
            this.labSN.TabIndex = 2;
            this.labSN.Text = "SurName";
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "LastName", true));
            this.txtLastName.Enabled = false;
            this.txtLastName.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLastName.Location = new System.Drawing.Point(142, 188);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(203, 27);
            this.txtLastName.TabIndex = 1;
            // 
            // labLN
            // 
            this.labLN.AutoSize = true;
            this.labLN.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labLN.Location = new System.Drawing.Point(33, 191);
            this.labLN.Name = "labLN";
            this.labLN.Size = new System.Drawing.Size(75, 20);
            this.labLN.TabIndex = 2;
            this.labLN.Text = "LastName";
            // 
            // txtBirthday
            // 
            this.txtBirthday.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Birthday", true));
            this.txtBirthday.Enabled = false;
            this.txtBirthday.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBirthday.Location = new System.Drawing.Point(142, 221);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(203, 27);
            this.txtBirthday.TabIndex = 1;
            // 
            // labBirthday
            // 
            this.labBirthday.AutoSize = true;
            this.labBirthday.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labBirthday.Location = new System.Drawing.Point(33, 224);
            this.labBirthday.Name = "labBirthday";
            this.labBirthday.Size = new System.Drawing.Size(64, 20);
            this.labBirthday.TabIndex = 2;
            this.labBirthday.Text = "Birthday";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "Phone", true));
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(142, 254);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(203, 27);
            this.txtPhone.TabIndex = 1;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labPhone.Location = new System.Drawing.Point(33, 257);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(50, 20);
            this.labPhone.TabIndex = 2;
            this.labPhone.Text = "Phone";
            // 
            // txtData
            // 
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "DataAdded", true));
            this.txtData.Enabled = false;
            this.txtData.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtData.Location = new System.Drawing.Point(142, 287);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(203, 27);
            this.txtData.TabIndex = 1;
            // 
            // labData
            // 
            this.labData.AutoSize = true;
            this.labData.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labData.Location = new System.Drawing.Point(33, 290);
            this.labData.Name = "labData";
            this.labData.Size = new System.Drawing.Size(86, 20);
            this.labData.TabIndex = 2;
            this.labData.Text = "DataAdded";
            // 
            // DapperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 689);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DapperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DapperForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butEdit;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labData;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Label labBirthday;
        private System.Windows.Forms.Label labLN;
        private System.Windows.Forms.Label labSN;
        private System.Windows.Forms.Label labFN;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}