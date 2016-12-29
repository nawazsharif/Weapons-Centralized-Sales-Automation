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
using System.Text.RegularExpressions;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Weapon_shop
{
    public partial class POS : Form
    {
       
        private int rowIndex = 0;
        Timer t = new Timer();
        public string customernid;
        public uint quantity;
        string time, date;
        WCSA_Entity_Classes.Product reference;
        MainForm mainFormReference;

        public POS()
        {
            InitializeComponent();
            this.ControlBox = false;
            timer1.Start();
           // dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_CellMouseClick);
        }
        public POS(MainForm mf )
        {
            InitializeComponent();
            this.ControlBox = false;
            LabelInvoice.Text = new POSPresenter().TransactionNumber().ToString();
            Admin.Text = mf.UserName;
            mainFormReference = mf;
            textinvoiceVAT.Text = VatForm.vat.ToString();
            LabelInvoice.Text = new POSPresenter().getCurrentInvoiceNumber().ToString();
            timer1.Start();

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {
            //t.Interval = 1000;//In milisecond 
            //t.Tick += new EventHandler(this.t_Tick);
            //t.Start();
            //new POSPresenter().Invoice();
            labelClock.Text = DateTime.Now.ToLongTimeString();
            time = labelClock.Text;
            date = DateTime.Now.ToShortDateString() ;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            // dataGridView1.MouseClick += new MouseEventHandler(dataGridView1_MouseClick);
            //this.Size = new Size();
            //dataGridView1.Size = new Size(450, 450);
            //string[] row_text= System.IO.File.ReadAllLines
        }
        //private void t_Tick(Object sender, EventArgs e)
        //{
        //    int hh = DateTime.Now.Hour;
        //    int mm = DateTime.Now.Minute;
        //    int ss = DateTime.Now.Second;

        //    string time = "";
        //    if (hh < 10)
        //    {
        //        time += "0" + hh;
        //    }
        //    else
        //    {
        //        time += hh;
        //    }
        //    time += ":";
        //    if (mm < 10)
        //    {
        //        time += "0" + mm;
        //    }
        //    else
        //    {
        //        time += mm;
        //    }
        //    time += ":";

        //    if (ss < 10)
        //    {
        //        time += "0" + ss;
        //    }
        //    else
        //    {
        //        time += ss;
        //    }
        //    labelClock.Text = time;

        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*
        Product code Text changed function starts here
        */
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            reference = new POSPresenter().returnProductDetails(textPCode.Text);
            if (reference != null)
            {
                textPCode.Text = reference.ProductCode;
                text_P_Name.Text = reference.ProductName;
                text_P_Name.Enabled = false;

                textQuantity.Text = null;

                //textTotalPrice.Text = tempProduct.Price.ToString();
                textTotalPrice.Enabled = false;

                textUnitPrice.Text = Convert.ToString(reference.Price);


            }
            else
            {
                Console.WriteLine("Product not returned");
            }
        }
        /*
        Product code Text changed function ends here
        */



        /*
        Item adition to invoice starts here
        */
        private void button1_Click(object sender, EventArgs e)
        {

        }
        /*
        Item adition to invoice ends here
        */



        /*
        Customer info add button functionality starts here
        */
        private void button3_Click(object sender, EventArgs e)
        {
           AddCustomerForm cs = new AddCustomerForm(this);
            cs.Show();
        }
        /*
        Customer info add button functionality ends here
        */



        /*
        Quantity text changed function starts here
        ------->Also calculates total cost
        */
        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            if (textQuantity.Text == "") {  }
            else {
                if (textQuantity.Text == null) textQuantity.Text = "0";


                if (reference != null)
                {
                    Debug.Assert(reference != null);

                    double quantity = Convert.ToDouble(textQuantity.Text);
                    double unitPrice = Convert.ToDouble(textUnitPrice.Text);
                    double totalPrice = Convert.ToDouble(quantity * unitPrice);
                    textTotalPrice.Text = Convert.ToString(totalPrice);

                }
            }

        }
        /*
        Quantity text changed function ends here
        */



        /*
        New Transaction button functions start here
        */
        private void button2_Click(object sender, EventArgs e)
        {
            new POSPresenter().newTransaction();

            textBoxInvoiceTotalCost.Text = null;
            dataGridView1.DataSource = null;
            textBoxInvoiceTotalItems.Text = Convert.ToString(0);
            LabelInvoice.Text = new POSPresenter().TransactionNumber().ToString();
        }
        /*
        New Transaction button functions end here
        */



        /*
        Print button functionality starts here
        */
        private void button7_Click(object sender, EventArgs e)
        {

            if (customernid == null)
            {
                MessageBox.Show("Please Fillup Customer Info");
            }
            else
            {
                MessageBox.Show("Successfull");

                uint num = new POSPresenter().generateInvoice(VatForm.vat, new POSPresenter().totalshopingAmount, date, time, Admin.Text, textBox1.Text, textBox2.Text);
                LabelInvoice.Text = num.ToString();
                new POSPresenter().newTransaction();

                textBoxInvoiceTotalCost.Text = null;
                dataGridView1.DataSource = null;
                textBoxInvoiceTotalItems.Text = Convert.ToString(0);

                customernid = null;
            }
        }
        /*
         Print button functionality ends here
        */



        /*
        Re-print button functionality starts here
        */
        private void button8_Click(object sender, EventArgs e)
        {
            Re_Print_Form rf = new Re_Print_Form();
            rf.Show(); 
        }
        /*
        Re-print button functionality ends here
        */


        
        private void label10_Click(object sender, EventArgs e)
        {

        }



        /*
        Item addition to POS table actions start here
        */
        private void textQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textQuantity_EnterKeyPressed(this, new EventArgs());
            }
        }
        private void textQuantity_EnterKeyPressed(object sender , EventArgs e)
        {
            if (reference != null)
            {
                uint originalQuantity = reference.Quantity;
                double VAT;
                uint quantity;

                /*
                Unnecessary code starts here
                */
                Console.WriteLine("Vat : " + mainFormReference.VAT.ToString());
                textinvoiceVAT.Text = VatForm.vat.ToString();
                /*
                Unnecessary code ends here
                */

                Debug.Assert(reference != null);

                if (double.TryParse(textinvoiceVAT.Text, out VAT))
                {
                    if (uint.TryParse(textQuantity.Text, out quantity))
                    {
                        if (quantity <= originalQuantity)
                        {
                            POSPresenter pp = new POSPresenter();
                            textBoxInvoiceTotalCost.Text = Convert.ToString(pp.addItemToInvoice(reference.ProductCode, Convert.ToDouble(reference.Price),
                            Convert.ToUInt32(textQuantity.Text), Convert.ToDouble(textinvoiceVAT.Text)));
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = null;
                            var list = new BindingList<WCSA_Entity_Classes.Product>(pp.getInvoiceItemsList());
                            dataGridView1.DataSource = list;
                            textBoxInvoiceTotalItems.Text = Convert.ToString(pp.getInvoiceItemsList().Count);

                            textPCode.Text = null;
                            textUnitPrice.Text = null;
                            text_P_Name.Text = null;
                            textQuantity.Text = null;
                            textUnitPrice.Enabled = true;
                            textPCode.Enabled = true;
                            text_P_Name.Enabled = true;
                            textTotalPrice.Text = null;
                            textBarCode.Text = null;

                            reference = null;
                           


                        }
                        else MessageBox.Show("Not enough items in stock");
                    }
                    else MessageBox.Show("Please enter quantity");
                }
                else MessageBox.Show("Please input VAT");
            }
            else
            {
                MessageBox.Show("Product Not found !");
            }
            
        }
        /*
        Item addition to POS table actions end here
        */

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void textBarCode_TextChanged(object sender, EventArgs e)
        {
            textPCode.Text = textBarCode.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                if(textBox1.Text != "")
                {
                    double paidAmount = Convert.ToDouble(textBox1.Text);
                    double totalCost = Convert.ToDouble(textBoxInvoiceTotalCost.Text);
                    double balance = paidAmount - totalCost;
                    textBox2.Text = balance.ToString();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows.RemoveAt(rowIndex);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
           
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deletRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
        }

        private void textBoxInvoiceTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labelClock.Text = datetime.ToString();
        }

        //void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        MessageBox.Show("Left");
        //    }
        //    else
        //    {

        //        ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
        //        //MessageBox.Show("Right");
        //        int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;
        //        //MessageBox.Show(position_xy_mouse_row.ToString());
        //        if (position_xy_mouse_row >= 0)
        //        {
        //            my_menu.Items.Add("Delete").Name = "Delete";
        //            my_menu.Items.Add("Edit").Name = "Edit";
        //            my_menu.Show(dataGridView1, new Point(e.X, e.Y));
        //            my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
        //        }
        //    }

        //}
        //private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{
        //    MessageBox.Show(e.ClickedItem.Name.ToString());
        //    switch (e.ClickedItem.Name.ToString())
        //    {
        //        case "Delete":
        //            break;
        //        case "Edit":
        //            break;
        //    }
        //}

        private void labelDate_Click(object sender, EventArgs e)
        {

        }
       

        

        /*
Item addition to POS table actions ends here
*/


    }
}
