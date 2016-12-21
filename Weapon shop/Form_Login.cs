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

            if (new WCSA_Service_Classes.LoginPagePresenter().checkIfAuthorized(textBoxUserName.Text,textBoxPassword.Text))
            {
                this.Hide();
                MainForm mf = new MainForm(this);
                MessageBox.Show("Login Successfull");
                this.textBoxUserName.Text = "";
                this.textBoxPassword.Text = "";
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
            get { return textBoxUserName.Text; }
        }
        public string Password
        {
            set { }
            get { return textBoxPassword.Text; }
        }
    }
}
