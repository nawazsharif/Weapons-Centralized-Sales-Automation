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
    public partial class SupplierInfoForm : Form
    {
        ManagerInfo reference;

        int chk;

        public SupplierInfoForm()
        {
            InitializeComponent();
            disable();
        }


        public SupplierInfoForm(ManagerInfo minfo)
        {
            InitializeComponent();
            reference = minfo;

        }
        public void disable()
        {
            groupBox2.Hide();
            textSearch.Hide();
            btnSearch.Hide();
            dataGridView1.Hide();
            btnOk.Hide();

        }
        private void SupplierInfoForm_Load(object sender, EventArgs e)
        {

        }



        private void btn_S_Search_Click(object sender, EventArgs e)
        {
            disable();
            // MessageBox.Show(Convert.ToString(chk));

            if (chk == 1)
            {
                disable();
                textSearch.Show();
                btnSearch.Show();
                groupBox2.Hide();
                dataGridView1.Show();


            }
            else if (chk == 0)
            {
                groupBox2.Show();
                textSearch.Hide();
                btnSearch.Hide();
                //btnOk.Hide();


            }
            else
            {
                textSearch.Hide();
                groupBox2.Show();
                btnSearch.Hide();
                btn_staff_add.Hide();
                btnOk.Show();

            }
        }

        private void btn_staff_add_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            disable();
            chk = 3;
            btnSearch.Show();
            textSearch.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            disable();
            chk = 1;
            dataGridView1.Show();
            textSearch.Show();
            btnSearch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disable();
            groupBox2.Show();
            btn_staff_add.Show();
            chk = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            btnOk.Show();
            btn_staff_add.Hide();
        }
    }



}