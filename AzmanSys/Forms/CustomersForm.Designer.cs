namespace AzmanSys
{
    partial class CustomerForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CusFName = new System.Windows.Forms.Label();
            this.CusLName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCustID = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.CusAge = new System.Windows.Forms.TextBox();
            this.tbCusGender = new System.Windows.Forms.TextBox();
            this.tbNationality = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCusTelNum = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerForms = new System.Windows.Forms.Label();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 235);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 229);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(561, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(637, 99);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(713, 62);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CusFName
            // 
            this.CusFName.AutoSize = true;
            this.CusFName.Location = new System.Drawing.Point(61, 72);
            this.CusFName.Name = "CusFName";
            this.CusFName.Size = new System.Drawing.Size(57, 13);
            this.CusFName.TabIndex = 5;
            this.CusFName.Text = "First Name";
            this.CusFName.Click += new System.EventHandler(this.Label2_Click);
            // 
            // CusLName
            // 
            this.CusLName.AutoSize = true;
            this.CusLName.Location = new System.Drawing.Point(61, 101);
            this.CusLName.Name = "CusLName";
            this.CusLName.Size = new System.Drawing.Size(58, 13);
            this.CusLName.TabIndex = 6;
            this.CusLName.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telephone Number";
            // 
            // tbCustID
            // 
            this.tbCustID.BackColor = System.Drawing.SystemColors.Control;
            this.tbCustID.Location = new System.Drawing.Point(135, 37);
            this.tbCustID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCustID.Name = "tbCustID";
            this.tbCustID.ReadOnly = true;
            this.tbCustID.Size = new System.Drawing.Size(85, 20);
            this.tbCustID.TabIndex = 4;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(135, 69);
            this.tbFName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(100, 20);
            this.tbFName.TabIndex = 9;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(135, 101);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(100, 20);
            this.tbLName.TabIndex = 10;
            // 
            // CusAge
            // 
            this.CusAge.Location = new System.Drawing.Point(135, 129);
            this.CusAge.Name = "CusAge";
            this.CusAge.Size = new System.Drawing.Size(38, 20);
            this.CusAge.TabIndex = 15;
            // 
            // tbCusGender
            // 
            this.tbCusGender.Location = new System.Drawing.Point(375, 69);
            this.tbCusGender.Name = "tbCusGender";
            this.tbCusGender.Size = new System.Drawing.Size(100, 20);
            this.tbCusGender.TabIndex = 0;
            // 
            // tbNationality
            // 
            this.tbNationality.Location = new System.Drawing.Point(375, 69);
            this.tbNationality.Name = "tbNationality";
            this.tbNationality.Size = new System.Drawing.Size(100, 20);
            this.tbNationality.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(375, 101);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(126, 20);
            this.tbAddress.TabIndex = 9;
            // 
            // tbCusTelNum
            // 
            this.tbCusTelNum.Location = new System.Drawing.Point(375, 144);
            this.tbCusTelNum.Name = "tbCusTelNum";
            this.tbCusTelNum.Size = new System.Drawing.Size(108, 20);
            this.tbCusTelNum.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.tbEmail.Location = new System.Drawing.Point(375, 180);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nationality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gender";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "CusAddress";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email";
            // 
            // CustomerForms
            // 
            this.CustomerForms.AutoSize = true;
            this.CustomerForms.Location = new System.Drawing.Point(61, 38);
            this.CustomerForms.Name = "CustomerForms";
            this.CustomerForms.Size = new System.Drawing.Size(62, 13);
            this.CustomerForms.TabIndex = 24;
            this.CustomerForms.Text = "CustomerID";
            // 
            // tbGender
            // 
            this.tbGender.Location = new System.Drawing.Point(375, 31);
            this.tbGender.Name = "tbGender";
            this.tbGender.Size = new System.Drawing.Size(59, 20);
            this.tbGender.TabIndex = 25;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(561, 165);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 35);
            this.btnMainMenu.TabIndex = 26;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.BtnMainMenu_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(678, 165);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.tbGender);
            this.Controls.Add(this.CustomerForms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbCusTelNum);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbNationality);
            this.Controls.Add(this.tbCusGender);
            this.Controls.Add(this.CusAge);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.tbCustID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CusLName);
            this.Controls.Add(this.CusFName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label CusFName;
        private System.Windows.Forms.Label CusLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCustID;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox CusAge;
        private System.Windows.Forms.TextBox tbCusGender;
        private System.Windows.Forms.TextBox tbNationality;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCusTelNum;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CustomerForms;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnExit;
    }
}