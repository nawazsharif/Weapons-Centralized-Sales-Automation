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
                WCSA_Entity_Classes.Staff srcStaf = new StaffInfoPresenter().checkStaffDetails(textBox_search.Text);
                textBoxName.Text = srcStaf.Name;
                textBoxName.Enabled = false;
                textBoxMail.Text = srcStaf.Mail;
                textBoxAddress.Text = srcStaf.Phone;
                textBoxPhone.Text = srcStaf.Address;
                textBoxNickName.Text = srcStaf.NickName;
                textBoxPassword.Text = srcStaf.Password;

            }
            else
            {
                textBox_search.Hide();
                btnsearch.Hide();
                groupBox2.Show();
                btn_staff_add.Hide();
                btnOk.Show();
                WCSA_Entity_Classes.Staff srcStaf = new StaffInfoPresenter().checkStaffDetails(textBox_search.Text);
                textBoxName.Text = srcStaf.Name;
                textBoxName.Enabled = false;
                textBoxMail.Text = srcStaf.Mail;
                textBoxAddress.Text = srcStaf.Phone;
                textBoxPhone.Text = srcStaf.Address;
                textBoxNickName.Text = srcStaf.NickName;
                textBoxPassword.Text = srcStaf.Password;
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
            dataGridView1.DataSource = new StaffInfoPresenter().fetchStaffList();

            //groupBox2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>() {
            //new Utility_Classes.Staff(StaffName,StaffMail, StaffPhone,StaffAddress, StaffNickname,StaffPassword)};
                new StaffInfoPresenter().Add(textBoxName.Text,textBoxMail.Text, textBoxPhone.Text, 
                                        textBoxAddress.Text, textBoxNickName.Text, textBoxPassword.Text);
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
            get { return textBoxName.Text; }
        }
        public string StaffMail
        {
            set { }
            get { return textBoxMail.Text; }
        }
        public string StaffPhone
        {
            set { }
            get { return textBoxAddress.Text; }
        }
        public string StaffAddress
        {
            set { }
            get { return textBoxPhone.Text; }
        }
        public string StaffNickname
        {
            set { }
            get { return textBoxNickName.Text; }
        }
        public string StaffPassword
        {
            set { }
            get { return textBoxPassword.Text; }
        }
        public string ConfirmPassword
        {
            set { }
            get { return textBoxConfirmPassword.Text; }
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void text_C_Password_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
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
            new StaffInfoPresenter().modifyStaffDetails(textBoxName.Text, textBoxMail.Text, textBoxPhone.Text,
                                        textBoxAddress.Text, textBoxNickName.Text, textBoxPassword.Text);
            MessageBox.Show("Edit Successfull");
        }
    }
}
