using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeVendor.Controls;

namespace Weapon_shop
{

    public partial class MainForm : Form
    {
        static double vat;
        Form_Login referwnce;
        private CodeVendor.Controls.Grouper Grouper1;
        
        public MainForm()
        {
            this.Grouper1 = new CodeVendor.Controls.Grouper();
            InitializeComponent();
           // this.ControlBox = false;
            //label3.Text = str;
            //MessageBox.Show(str);
            this.WindowState = FormWindowState.Maximized;
        }
        public MainForm(Form_Login lgfm)
        {
            this.Grouper1 = new CodeVendor.Controls.Grouper();
            InitializeComponent();
            //this.ControlBox = false;
            label3.Text = lgfm.UserName;
            referwnce = lgfm;
        }

        public double VAT
        {
            set
            {
                vat = value;
            }
            get
            {
                return vat;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
            string time = labelClock.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Product pd = new Product(this);
            pd.Show();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            POS ps = new POS(this);
            ps.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff(this);
            staff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StockInfoForm sf = new StockInfoForm();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CustomerForm cm = new CustomerForm();
            cm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            referwnce.Show();
            this.Close();
        }
        
        public void label3_Click(object sender, EventArgs e)
        {
            
        }

        public string UserName
        {
            get { return label3.Text; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SellsInfo sf = new SellsInfo();
            sf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManagerLogin mlog = new ManagerLogin();
            mlog.Show();
        }

        private void setingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutShopForm fm = new AboutShopForm();
            fm.Show();
        }

        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VatForm vf = new VatForm(this);
            vf.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Show();
        }

        private void staffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Staff().Show();
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Product().Show();
        }

        private void customerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CustomerForm().Show();
        }

        private void sellsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SellsInfo().Show();
        }

        private void grouper2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.labelClock.Text = datetime.ToString();
        }
    }
}
