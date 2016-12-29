using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataConnection;

namespace Weapon_shop
{
    public partial class DataBaseForm : Form
    {
        public DataBaseForm()
        {
            InitializeComponent();
            dataGridView1.Hide();
            //this.ControlBox = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new StaffDataAccess().GetAll();
            dataGridView1.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new ProductDataAccess().GetAll();
            dataGridView1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new CustomerDataAccess().GetAll();
            dataGridView1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new InvoiceDataAccess().GetAll();
            dataGridView1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BankAccountDataAccess().GetAll();
            dataGridView1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        
    }
}
