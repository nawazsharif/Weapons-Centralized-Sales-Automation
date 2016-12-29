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
using System.IO;
using System.Drawing.Imaging;

namespace Weapon_shop
{
    public partial class Product : Form
    {
        int rowIndex = 0;
        MainForm rfrence;
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
            groupBox3.Hide();
           

        }
        public Product()
        {
            InitializeComponent();
            disable_product();
            this.ControlBox = false;
        }
        public Product(MainForm mf)
        {
            InitializeComponent();
            disable_product();
            this.ControlBox = false;
            rfrence = mf;
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
                dataGridView1.DataSource = null;
                List<WCSA_Entity_Classes.Product> stflist = new List<WCSA_Entity_Classes.Product>();
                stflist.Add(new ProductPresenter().checkProductDetails(textSearch.Text));
                //foreach (WCSA_Entity_Classes.Product st in stflist)
                //{
                //    Console.WriteLine("Staff name : " + st.ProductName);
                //}
                if(stflist.Count != 0)
                {
                    dataGridView1.DataSource = stflist;
                    dataGridView1.Show();
                }
                
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

                if (textSearch.Text == "")
                {
                    disable_product();
                    groupBox2.Hide();
                    textSearch.Show();
                    btn_P_Search.Show();
                    MessageBox.Show("Please Insert A Valid Product Code");
                }
                else
                {
                    WCSA_Entity_Classes.Product srcProd = new ProductPresenter().checkProductDetails(textSearch.Text);
                    if (srcProd != null)
                    {

                        textBoxCode.Text = srcProd.ProductCode;
                        textBoxName.Text = srcProd.ProductName;
                        textBoxPrice.Text = Convert.ToString(srcProd.Price);
                        textBoxQuantity.Text = Convert.ToString(srcProd.Quantity);
                    }
                    else
                    {
                        disable_product();
                        groupBox2.Hide();
                        textSearch.Show();
                        btn_P_Search.Show();
                        MessageBox.Show("Not Found");

                    }

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            disable_product();
            chk = 0;
            groupBox2.Show();
            btn_P_add.Show();
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
            double price;
            uint quantity;
            if (textBoxName.Text == "") { MessageBox.Show("Please enter Product Name"); }
            if (textBoxCode.Text == "") { MessageBox.Show("Please enter Product Code"); }

            else {
                if (double.TryParse(textBoxPrice.Text, out price))
                {
                    if (uint.TryParse(textBoxQuantity.Text, out quantity))
                    {

                        if (textBoxName.Text != "" && textBoxCode.Text != null && textBoxQuantity.Text != null && textBoxPrice.Text != null)
                        {
                            new ProductPresenter().Add(textBoxCode.Text, textBoxName.Text, price, quantity);
                            MessageBox.Show("Successfull");
                            groupBox2.Hide();
                        }
                    else
                    {
                        MessageBox.Show("FillUp all Data");

                    }
                    }
                    else MessageBox.Show("Please enter quantity");
                }
                else MessageBox.Show("Please input price");
            }
        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double price;
            uint quantity;
            if (double.TryParse(textBoxPrice.Text, out price))
            {
                if (uint.TryParse(textBoxQuantity.Text, out quantity))
                {
                    new ProductPresenter().modifyItem(textBoxCode.Text, textBoxName.Text, price, quantity);
                    MessageBox.Show("Successfull");
                }
                else MessageBox.Show("Please enter quantity");
            }
            else MessageBox.Show("Please input price");
        }
        public Image dorkar;
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            rfrence.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            disable_product();
            groupBox3.Show();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBarcode.Text == "") { }
            else
            {
                Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                pictureBox3.Image = barcode.Draw(textBarcode.Text, 50);
            }

        //string barcode = textBarcode.Text;
        //Bitmap bit = new Bitmap(barcode.Length * 40, 150);
        //using (Graphics graphice = Graphics.FromImage(bit))
        //{

            //    Font bfont = new System.Drawing.Font("IDAutomationHC39M", 20);
            //    PointF point = new PointF(2f, 2f);
            //    SolidBrush black = new SolidBrush(Color.Black);
            //    SolidBrush white = new SolidBrush(Color.White);
            //    graphice.FillRectangle(white, 0, 0, bit.Width, bit.Height);
            //    graphice.DrawString("*" + barcode + "*", bfont, black, point);
            //    using (MemoryStream memo = new MemoryStream())
            //    {
            //        bit.Save(memo, ImageFormat.Png);
            //        pictureBox2.Image = bit;
            //        pictureBox2.Height = bit.Height;
            //        pictureBox2.Width = bit.Width;
            //    }
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBarcode.Text == "") { }
            else
            {
                Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                pictureBox3.Image = qrcode.Draw(textBarcode.Text, 50);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dataGridView1, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                Staff pp = new Staff();
                // this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
                new ProductPresenter().DeleteProduct(dataGridView1.CurrentCell.Value.ToString());
                dataGridView1.DataSource = new ProductPresenter().fetchProductList();
            }
        }
    }
}
