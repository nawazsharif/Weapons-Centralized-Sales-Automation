using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon_shop
{
    public partial class Customer : Form
    {
        int chk = 0;
        public void disable_C() { 
        dataGridView1.Hide();
            groupBox2.Hide();
            textSearch.Hide();
            btnSearch.Hide();
            btnOk.Hide();
            }
        public Customer()
        {
            InitializeComponent();
            disable_C();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (chk == 4)
            {

                disable_C();
                textSearch.Show();
                btnSearch.Show();
                groupBox2.Hide();
                dataGridView1.Show();

            }
            else if (chk == 0)
            {

                textSearch.Hide();
                btnSearch.Hide();
                groupBox2.Show();
                btn_P_add.Show();

            }
            else if (chk == 2)
            {

                textSearch.Hide();
                btnSearch.Hide();
                groupBox2.Show();
                btn_P_add.Hide();
                btnOk.Show();

            }
            else
            {
                disable_C();
                textSearch.Show();
                btnSearch.Show();
                groupBox2.Hide();
                dataGridView1.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable_C();
            chk = 4;
            textSearch.Show();
            btnSearch.Show();
   

            dataGridView1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            disable_C();
            chk = 0;
            groupBox2.Show();
            btnOk.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            disable_C();
            chk = 2;
            textSearch.Show();
            btnSearch.Show();
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            disable_C();
            chk = 3;
            textSearch.Show();
            btnSearch.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }
    }
}
