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
    public partial class Product : Form
    {
        string code;
        string name;
        uint quantity;
        double price;
        string searchCode;

        int chk = 0;
        public void disable_product()
        {
            dataGridView1.Hide();
            groupBox2.Hide();
            textSearch.Hide();
            btn_P_Search.Hide();
            btnOk.Hide();
           

        }
        public Product()
        {
            InitializeComponent();
            disable_product();
            this.ControlBox = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (chk == 1)
            {
                // Show all Button Function
                disable_product();
                textSearch.Show();
                btn_P_Search.Show();
                groupBox2.Hide();
                dataGridView1.Show();
                //dataGridView1.DataSource = new ProductPresenter().fetchProductList() ;

            }
            else if (chk == 0)
            {
                // Add button function
                textSearch.Hide();
                btn_P_Search.Hide();
                groupBox2.Show();
                btn_P_add.Show();
                WCSA_Entity_Classes.Product srcProd = new ProductPresenter().checkProductDetails(textSearch.Text);
                textBoxCode.Text = srcProd.ProductCode;
                textBoxName.Text = srcProd.ProductName;
                textBoxPrice.Text = Convert.ToString(srcProd.Price);
                textBoxQuantity.Text = Convert.ToString(srcProd.Quantity);

            }
            else
            {
                // Update button function
                textSearch.Hide();
                btn_P_Search.Hide();
                groupBox2.Show();
                btn_P_add.Hide();
                btnOk.Show();
                WCSA_Entity_Classes.Product srcProd = new ProductPresenter().checkProductDetails(textSearch.Text);
                if(srcProd != null)
                {
                    textBoxCode.Text = srcProd.ProductCode;
                    textBoxName.Text = srcProd.ProductName;
                    textBoxPrice.Text = Convert.ToString(srcProd.Price);
                    textBoxQuantity.Text = Convert.ToString(srcProd.Quantity);
                }
                else
                {
                    MessageBox.Show("Product Not found !"); 
                }
                

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disable_product();
            chk = 0;
            groupBox2.Show();
            btnOk.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disable_product();
            chk = 3;
            textSearch.Show();
            btn_P_Search.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable_product();
            chk = 1;
            textSearch.Show();
            btn_P_Search.Show();
            dataGridView1.DataSource = null;
            //List<WCSA_Entity_Classes.Product> pl = new ProductPresenter().fetchProductList();
            dataGridView1.Show();
            //dataGridView1.DataSource = pl;
            //dataGridView1.DataSource = new ProductPresenter().fetchProductList();
            dataGridView1.DataSource = new ProductPresenter().fetchProductList();

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        

        public string ProductCode
        {
            set
            {
                code = textBoxCode.Text;
            }
            get { return textBoxCode.Text; }
        }
        public string ProductName
        {
            set
            {
                //name = value;
            }
            get { return textBoxName.Text; }
        }
        public double Price
        {
            set
            {
                   price = value;
            }
            get {if (textBoxPrice.Text == "") return 0;
                else return Convert.ToDouble(textBoxPrice.Text); }
        }
        public uint Quantity
        {
            set
            {
                quantity = value;
            }
            get {if (textBoxQuantity.Text == "") return 0;
                else return Convert.ToUInt32(textBoxQuantity.Text); }
        }

        private void Product_Load_1(object sender, EventArgs e)
        {

        }
        //public Image Picture
        //{
        //    set
        //    {
        //        picture = value;
        //    }
        //    get { return picture; }
        //}
        public string SearchCode
        {
            set
            {
                searchCode = textSearch.Text;
            }
            get { return textSearch.Text; }
        }

        private void btn_staff_add_Click(object sender, EventArgs e)
        {
            new ProductPresenter().Add(textBoxCode.Text,textBoxName.Text,Convert.ToDouble(textBoxPrice.Text),
                Convert.ToUInt32(textBoxQuantity.Text));
            MessageBox.Show("Successfull");
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
