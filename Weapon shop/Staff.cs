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
    public partial class Staff : Form
    {
        int chk ;
        public void disable()
        {
            textBox_search.Hide();
            btnsearch.Hide();
            groupBox2.Hide();
            dataGridView1.Hide();
            

        }
        public Staff()
        {
            InitializeComponent();
            this.ControlBox = false;
            disable();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grouper2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disable() ;
            chk = 0;
            groupBox2.Show();
            btnOk.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
            chk = 3;
            btnsearch.Show();
            textBox_search.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            disable();
            // MessageBox.Show(Convert.ToString(chk));

            if (chk == 1)
            {
                disable();
                textBox_search.Show();
                btnsearch.Show();
                groupBox2.Hide();
                dataGridView1.Show();


            }
            else if (chk == 0)
            {
                textBox_search.Hide();
                btnsearch.Hide();
                groupBox2.Show();
                //btnOk.Hide();
                Utility_Classes.Staff srcStaf = new Presenter_Classes.StaffInfoPresenter(this).checkStaffDetails(textBox_search.Text);
                textBox1.Text = srcStaf.Name;
                textBox1.Enabled = false;
                textBox2.Text = srcStaf.Mail;
                textBox3.Text = srcStaf.Phone;
                textBox4.Text = srcStaf.Address;
                textBox5.Text = srcStaf.NickName;
                textPassword.Text = srcStaf.Password;

            }
            else
            {
                textBox_search.Hide();
                btnsearch.Hide();
                groupBox2.Show();
                btn_staff_add.Hide();
                btnOk.Show();
                Utility_Classes.Staff srcStaf = new Presenter_Classes.StaffInfoPresenter(this).checkStaffDetails(textBox_search.Text);
                textBox1.Text = srcStaf.Name;
                textBox1.Enabled = false;
                textBox2.Text = srcStaf.Mail;
                textBox3.Text = srcStaf.Phone;
                textBox4.Text = srcStaf.Address;
                textBox5.Text = srcStaf.NickName;
                textPassword.Text = srcStaf.Password;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show data
            disable();
            chk = 1;
            dataGridView1.Show();
            textBox_search.Show();
            btnsearch.Show();
            dataGridView1.DataSource = new Weapon_shop.Presenter_Classes.StaffInfoPresenter(this).fetchStaffList();

            //groupBox2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>() {
            //new Utility_Classes.Staff(StaffName,StaffMail, StaffPhone,StaffAddress, StaffNickname,StaffPassword)};
                new Weapon_shop.Presenter_Classes.StaffInfoPresenter(this).Add();
                MessageBox.Show("Successfull");
                this.Hide();
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string StaffName
        {
            set { }
            get { return textBox1.Text; }
        }
        public string StaffMail
        {
            set { }
            get { return textBox2.Text; }
        }
        public string StaffPhone
        {
            set { }
            get { return textBox3.Text; }
        }
        public string StaffAddress
        {
            set { }
            get { return textBox4.Text; }
        }
        public string StaffNickname
        {
            set { }
            get { return textBox5.Text; }
        }
        public string StaffPassword
        {
            set { }
            get { return textPassword.Text; }
        }
        public string ConfirmPassword
        {
            set { }
            get { return text_C_Password.Text; }
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void text_C_Password_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text == text_C_Password.Text)
            {
                label8.Text = "Password Matched";
            }
            else
            {
                label8.Text = "Password Not Matched";
            }
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            new Presenter_Classes.StaffInfoPresenter(this).modifyStaffDetails();
            MessageBox.Show("Edit Successfull");
        }
    }
}
