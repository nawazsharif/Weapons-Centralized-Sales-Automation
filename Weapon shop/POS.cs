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
            get { return Convert.ToUInt32(textTotalItems.Text); }
        }
        public double InvoiceTotalVAT
        {
            set { }
            get { return Convert.ToDouble(textinvoiceVAT.Text); }
        }
        public double InvoiceTotalPrice
        {
            set { }
            get { return Convert.ToDouble(textBox9.Text); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Utility_Classes.Product tempProduct = new Presenter_Classes.POSPresenter(this).ReturnProductIfPossible();
            //if(tempProduct != null)
            //{
            //    textPCode.Text = tempProduct.ProductCode;
            //    textPCode.Enabled = false;
            //    text_P_Name.Text = tempProduct.ProductName;
            //    text_P_Name.Enabled = false;

            //    textQuantity.Text = "";

            //    textTotalPrice.Text = tempProduct.Price.ToString();
            //    textTotalPrice.Enabled = false;


            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Presenter_Classes.POSPresenter(this).AddToPurchaseList();
            WCSA_Entity_Classes.Product srcProd = new POSPresenter().returnProductDetails(textPCode.Text);
            if (srcProd != null)
            {
                textPCode.Text = srcProd.ProductCode;
                text_P_Name.Text = srcProd.ProductName;
                textUnitPrice.Text = Convert.ToString(srcProd.Price);
               // textQuantity.Text = Convert.ToString(srcProd.Quantity);
            }
            else
            {
                MessageBox.Show("Product Not found !");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer cs = new Customer();
            cs.Show();
        }

    }
}
