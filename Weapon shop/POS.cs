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
    public partial class POS : Form
    {
        public string customernid;
        public uint quantity;
        Product reference;
        public POS()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public POS(MainForm mf )
        {
            InitializeComponent();
            this.ControlBox = false;
            Admin.Text = mf.UserName;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void POS_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string BarCode
        {
            set { }
            get { return textBarCode.Text; }
        }
        public string ProductCode
        {
            set { }
            get { return textPCode.Text; }
        }
        public string newProductName
        {
            set { }
            get { return text_P_Name.Text; }
        }
        public uint Quantity
        {
            set { this.quantity = Convert.ToUInt32(textQuantity.Text); }
            get {
                 
                return Convert.ToUInt32(textQuantity.Text);
            }
        }

        public double UnitPrice
        {
            set {  }
            get {
                 return Convert.ToDouble(textUnitPrice.Text);
            }
        }
        public double TotalPrice
        {
            set { }
            get {
                return Convert.ToDouble( textTotalPrice.Text);
            }
        }
        public uint InvoiceTotalItems
        {
            set { }
            get { return Convert.ToUInt32(textBoxInvoiceTotalItems.Text); }
        }
        public double InvoiceTotalVAT
        {
            set { }
            get { return Convert.ToDouble(textinvoiceVAT.Text); }
        }
        public double InvoiceTotalPrice
        {
            set { }
            get { return Convert.ToDouble(textBoxInvoiceTotalCost.Text); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            WCSA_Entity_Classes.Product tempProduct = new POSPresenter().returnProductDetails(textPCode.Text);
            if (tempProduct != null)
            {
                textPCode.Text = tempProduct.ProductCode;
                text_P_Name.Text = tempProduct.ProductName;
                text_P_Name.Enabled = false;

                textQuantity.Text = "";

                //textTotalPrice.Text = tempProduct.Price.ToString();
                textTotalPrice.Enabled = false;

                textUnitPrice.Text = Convert.ToString(tempProduct.Price);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Presenter_Classes.POSPresenter(this).AddToPurchaseList();
            WCSA_Entity_Classes.Product srcProd = new POSPresenter().returnProductDetails(textPCode.Text);
            if (srcProd != null)
            {
                uint originalQuantity=srcProd.Quantity;
                double VAT;
                uint quantity;
                if (double.TryParse(textQuantity.Text, out VAT))
                {
                    if (uint.TryParse(textinvoiceVAT.Text, out quantity))
                    {
                        if (quantity <= originalQuantity)
                        {
                            POSPresenter pp = new POSPresenter();
                            textBoxInvoiceTotalCost.Text = Convert.ToString(pp.addItemToInvoice(textPCode.Text, Convert.ToDouble(textUnitPrice.Text),
                               quantity, VAT));
                            dataGridView1.DataSource = pp.getInvoiceItemsList();
                            textBoxInvoiceTotalItems.Text = Convert.ToString(pp.getInvoiceItemsList().Count);

                            textPCode.Text = "";
                            textUnitPrice.Text = "";
                            text_P_Name.Text ="";
                            textQuantity.Text = "";
                            textUnitPrice.Enabled = true;
                            textPCode.Enabled = true;
                            text_P_Name.Enabled = true;
                            textTotalPrice.Text = "";


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

        private void button3_Click(object sender, EventArgs e)
        {
           AddCustomerForm cs = new AddCustomerForm(this);
            cs.Show();
        }

        private void textQuantity_TextChanged(object sender, EventArgs e)
        {
            if(textPCode.Text != "")
                textTotalPrice.Text = Convert.ToString(Convert.ToDouble(textUnitPrice.Text) * Convert.ToUInt32(textQuantity.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new POSPresenter().newTransaction();
            textBoxInvoiceTotalCost.Text = "";
            dataGridView1.DataSource = null;
            textBoxInvoiceTotalItems.Text = Convert.ToString(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (customernid == null)
            {
                MessageBox.Show("Please Fillup Customer Info");
                
            }
            else
            {
                MessageBox.Show("Successfull");
                customernid = null;
            }
        }
    }
}
