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
        public string str;
        public void disable()
        {
            Pdfreader.Hide();
            button1.Hide();

        }
        //private 
        public Re_Print_Form()
        {
            
            InitializeComponent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = new RePrintPresenter().returnInvoiceList();
            dataGridView1.Show();
            disable();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if (textBox1.Text != "")
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


        

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //String str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //MessageBox.Show(str);
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
             str =  dataGridView1.CurrentCell.Value.ToString();
            string Path = "C:\\Users\\ahmed\\Desktop\\PDF\\" + str+".pdf" ;
            

            if (Path != null)
            {

                Pdfreader.src = Path;
                Pdfreader.Show();
                textBox1.Hide();
                button1.Show();
                dataGridView1.Hide();
            }
        }

        private void Re_Print_Form_Load(object sender, EventArgs e)
        {
            disable();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disable();
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
