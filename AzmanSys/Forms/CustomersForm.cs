using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys
{
    public partial class CustomerForm : Form
    {
        customerDbConn mysqlConn;
        public CustomerForm()
        {
            InitializeComponent();
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
            if (mysqlConn.connOpen() == true)
            {
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.insertCustomer(tbCustID.Text, tbFName.Text, tbLName.Text, CusAge.Text, tbCusGender.Text, tbNationality.Text, tbAddress.Text, tbCusTelNum.Text, tbEmail.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tbCustID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tbFName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tbLName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                CusAge.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                tbCusGender.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                tbNationality.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                tbAddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbCusTelNum.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                tbEmail.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (mysqlConn.connOpen() == true)
            {
                mysqlConn.updateCustomer(tbCustID.Text, tbFName.Text, tbLName.Text, CusAge.Text, tbCusGender.Text, tbNationality.Text, tbAddress.Text, tbCusTelNum.Text, tbEmail.Text);
                dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
            }
            mysqlConn.connClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this record ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                if (mysqlConn.connOpen() == true)
                {
                    mysqlConn.deleteCustomer(tbCustID.Text);
                    dataGridView1.DataSource = mysqlConn.qry("SELECT * FROM `tblCustomer`").Tables[0];
                }
                mysqlConn.connClose();
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMainMenu_Click_1(object sender, EventArgs e)
        {
            Close();
            (new MainForm()).Show();
        }
    }
}
