using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;

namespace Weapon_shop
{
    public partial class BankAccountForm : Form
    {
        ManagerInfo minfo;
        public BankAccountForm()
        {
            InitializeComponent();
            disable();
        }
        public BankAccountForm(ManagerInfo mg)
        {
            InitializeComponent();
            disable();
            minfo = mg;

        }
        public void disable()
        {
            dataGridView1.Hide();
            groupBox2.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BankAccountForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disable();
            groupBox2.Show();        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            disable();
            dataGridView1.DataSource = new BankAccountPresenter().fetchBankList();
            dataGridView1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            minfo.Show();
        }

        private void btn_staff_add_Click(object sender, EventArgs e)
        {
            new BankAccountPresenter().Add(textBox1.Text, textBox2.Text, textBox3.Text);
            MessageBox.Show("Successfull");
        }

        private void grouper1_Load(object sender, EventArgs e)
        {

        }
    }
}
