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
    public partial class Re_Print_Form : Form
    {
        public Re_Print_Form()
        {
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new RePrintPresenter().returnInvoiceList();
            dataGridView1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!=null)
            {
                if(textBox1.Text != "")
                {
                    Invoice inv = new RePrintPresenter().getAnInvoice(Convert.ToUInt32(textBox1.Text));
                    if (inv != null)
                    {
                        List<Invoice> tempList = new List<Invoice>();

                        tempList.Add(inv);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = tempList;
                        dataGridView1.Show();
                    }
                    else
                        Console.WriteLine("Invoice not found");
                }
            }
            
            

        }
    }
}
