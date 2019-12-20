namespace AzmanSys
{
    partial class FlightsForm
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
            this.tbDepartureCity = new System.Windows.Forms.TextBox();
            this.tbFlightID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbAdultPrice = new System.Windows.Forms.TextBox();
            this.tbChildPrice = new System.Windows.Forms.TextBox();
            this.tbInfantPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.dtDepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.tbArrivalCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDepartureCity
            // 
            this.tbDepartureCity.Location = new System.Drawing.Point(534, 139);
            this.tbDepartureCity.Name = "tbDepartureCity";
            this.tbDepartureCity.Size = new System.Drawing.Size(100, 20);
            this.tbDepartureCity.TabIndex = 24;
            // 
            // tbFlightID
            // 
            this.tbFlightID.Enabled = false;
            this.tbFlightID.Location = new System.Drawing.Point(136, 30);
            this.tbFlightID.Name = "tbFlightID";
            this.tbFlightID.ReadOnly = true;
            this.tbFlightID.Size = new System.Drawing.Size(100, 20);
            this.tbFlightID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Departure City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Arrival Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Depature Date and time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Flight ID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(261, 158);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 209);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 188);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(534, 16);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 23;
            // 
            // tbAdultPrice
            // 
            this.tbAdultPrice.Location = new System.Drawing.Point(535, 46);
            this.tbAdultPrice.Name = "tbAdultPrice";
            this.tbAdultPrice.Size = new System.Drawing.Size(100, 20);
            this.tbAdultPrice.TabIndex = 23;
            // 
            // tbChildPrice
            // 
            this.tbChildPrice.Location = new System.Drawing.Point(534, 71);
            this.tbChildPrice.Name = "tbChildPrice";
            this.tbChildPrice.Size = new System.Drawing.Size(100, 20);
            this.tbChildPrice.TabIndex = 35;
            // 
            // tbInfantPrice
            // 
            this.tbInfantPrice.Location = new System.Drawing.Point(534, 98);
            this.tbInfantPrice.Name = "tbInfantPrice";
            this.tbInfantPrice.Size = new System.Drawing.Size(100, 20);
            this.tbInfantPrice.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Adult Price";
            // 
            // dtArrivalDateTime
            // 
            this.dtArrivalDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtArrivalDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtArrivalDateTime.Location = new System.Drawing.Point(136, 98);
            this.dtArrivalDateTime.Name = "dtArrivalDateTime";
            this.dtArrivalDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtArrivalDateTime.TabIndex = 22;
            // 
            // dtDepartureDateTime
            // 
            this.dtDepartureDateTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.dtDepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDepartureDateTime.Location = new System.Drawing.Point(136, 65);
            this.dtDepartureDateTime.Name = "dtDepartureDateTime";
            this.dtDepartureDateTime.Size = new System.Drawing.Size(200, 20);
            this.dtDepartureDateTime.TabIndex = 21;
            // 
            // tbArrivalCity
            // 
            this.tbArrivalCity.Location = new System.Drawing.Point(534, 165);
            this.tbArrivalCity.Name = "tbArrivalCity";
            this.tbArrivalCity.Size = new System.Drawing.Size(100, 20);
            this.tbArrivalCity.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Arrival City";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Child Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Infant Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Price";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(69, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FlightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbChildPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbArrivalCity);
            this.Controls.Add(this.dtDepartureDateTime);
            this.Controls.Add(this.dtArrivalDateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbAdultPrice);
            this.Controls.Add(this.tbInfantPrice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbDepartureCity);
            this.Controls.Add(this.tbFlightID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "FlightsForm";
            this.Text = "Flight Form";
            this.Load += new System.EventHandler(this.FlightsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDepartureCity;
        private System.Windows.Forms.TextBox tbFlightID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbAdultPrice;
        private System.Windows.Forms.TextBox tbInfantPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtArrivalDateTime;
        private System.Windows.Forms.DateTimePicker dtDepartureDateTime;
        private System.Windows.Forms.TextBox tbArrivalCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbChildPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
    }
}