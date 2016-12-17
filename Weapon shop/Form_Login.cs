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
    public partial class Form_Login : Form
    {
       
        private CodeVendor.Controls.Grouper Grouper1;
        public Form_Login()
        {
            this.Grouper1 = new CodeVendor.Controls.Grouper();
            InitializeComponent();
            this.ControlBox = false;
            
        }


        private void Form_login_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (new Weapon_shop.Presenter_Classes.LoginPagePresenter(this).checkIfAuthorized())
            {
                this.Hide();
                MainForm mf = new MainForm(this);
                MessageBox.Show("Login Successfull");
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                mf.Show();
                
                //MessageBox.Show(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Invalid Username Password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string UserName
        {
            set { }
            get { return textBox1.Text; }
        }
        public string Password
        {
            set { }
            get { return textBox2.Text; }
        }
    }
}
