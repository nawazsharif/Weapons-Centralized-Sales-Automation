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
    public partial class CustomerForm : Form
    {
        int chk = 0;
        
        public CustomerForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = new CustomerPresenter().fetchCustomerList();
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


        /*
        Search button functionality starts here
        */
        private void button3_Click(object sender, EventArgs e)
        {
            
            WCSA_Entity_Classes.Customer customer = new CustomerPresenter().checkcustomerDetails(textSearch.Text);
            if(customer != null)
            {
                dataGridView1.DataSource = null;
                List<Customer> customerList = new List<Customer>();
                customerList.Add(customer);
                dataGridView1.DataSource = customer;

            }
        }
        /*
        Search button functionality ends here
        */

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
