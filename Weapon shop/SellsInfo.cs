using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCSA_Entity_Classes;
using WCSA_Service_Classes;

namespace Weapon_shop
{
    public partial class SellsInfo : Form
    {
        public SellsInfo()
        {
            InitializeComponent();
            dataGridView1.Hide();

            List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tempList;
            dataGridView1.Show();

            this.WindowState = FormWindowState.Maximized;
        }

        private void SellsInfo_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByStaffName();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByInvoiceNumber();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            
        }
    }
}
