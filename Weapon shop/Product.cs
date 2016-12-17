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
                dataGridView1.DataSource = new Weapon_shop.Presenter_Classes.ProductPresenter(this).fetchProductList() ;

            }
            else if (chk == 0)
            {
                // Add button function
                textSearch.Hide();
                btn_P_Search.Hide();
                groupBox2.Show();
                btn_P_add.Show();
                Utility_Classes.Product srcProd = new Presenter_Classes.ProductPresenter(this).checkProductDetails(textSearch.Text);
                textCode.Text = srcProd.ProductCode;
                textName.Text = srcProd.ProductName;
                textPrice.Text = Convert.ToString(srcProd.Price);
                textQuantity.Text = Convert.ToString(srcProd.Quantity);

            }
            else
            {
                // Update button function
                textSearch.Hide();
                btn_P_Search.Hide();
                groupBox2.Show();
                btn_P_add.Hide();
                btnOk.Show();
                Utility_Classes.Product srcProd = new Presenter_Classes.ProductPresenter(this).checkProductDetails(textSearch.Text);
                if(srcProd != null)
                {
                    textCode.Text = srcProd.ProductCode;
                    textName.Text = srcProd.ProductName;
                    textPrice.Text = Convert.ToString(srcProd.Price);
                    textQuantity.Text = Convert.ToString(srcProd.Quantity);
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
            List<Utility_Classes.Product> pl = new Weapon_shop.Presenter_Classes.ProductPresenter(this).fetchProductList();
            dataGridView1.DataSource = pl;

            dataGridView1.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        

        public string ProductCode
        {
            set
            {
                code = textCode.Text;
            }
            get { return textCode.Text; }
        }
        public string ProductName
        {
            set
            {
                //name = value;
            }
            get { return textName.Text; }
        }
        public double Price
        {
            set
            {
                   price = value;
            }
            get {if (textPrice.Text == "") return 0;
                else return Convert.ToDouble(textPrice.Text); }
        }
        public uint Quantity
        {
            set
            {
                quantity = value;
            }
            get {if (textQuantity.Text == "") return 0;
                else return Convert.ToUInt32(textQuantity.Text); }
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
            new Weapon_shop.Presenter_Classes.ProductPresenter(this).Add();
            MessageBox.Show("Successfull");
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
