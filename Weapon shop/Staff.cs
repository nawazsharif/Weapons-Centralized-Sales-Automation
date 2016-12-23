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
        public int chk ;
        public string str;
        MainForm refrence;
        public void disable()
        {
            textBox_search.Hide();
            btnsearch.Hide();
            groupBox2.Hide();
            dataGridView1.Hide();
            

        }
        public void refresh()
        {
            textBox_search.Text = "";
            textBoxName.Text = "";
            textBoxMail.Text = "";
            textBoxNickName.Text = "";
            textBoxPhone.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxAddress.Text = "";
        }
        public Staff()
        {
            InitializeComponent();
            this.ControlBox = false;
            disable();
            refresh();
        }
        public Staff(MainForm mf)
        {
            InitializeComponent();
            this.ControlBox = false;
            disable();
            this.refrence = mf;
            refresh();
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
            refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
            chk = 3;
            btnsearch.Show();
            textBox_search.Show();
            refresh();
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
            else if (chk == 0)// add button
            {
                textBox_search.Hide();
                btnsearch.Hide();
                groupBox2.Show();
                //btnOk.Hide();
                //WCSA_Entity_Classes.Staff srcStaf = new StaffInfoPresenter().checkStaffDetails(textBox_search.Text);
                //textBoxName.Text = srcStaf.Name;
                //textBoxName.Enabled = false;
                //textBoxMail.Text = srcStaf.Mail;
                //textBoxAddress.Text = srcStaf.Phone;
                //textBoxPhone.Text = srcStaf.Address;
                //textBoxNickName.Text = srcStaf.NickName;
                //textBoxPassword.Text = srcStaf.Password;

            }
            else//update button
            {
                textBox_search.Hide();
                btnsearch.Hide();
                groupBox2.Show();
                btn_staff_add.Hide();
                btnOk.Show();
                if (textBox_search.Text == "")
                {
                    disable();
                    groupBox2.Hide();
                    textBox_search.Show();
                    btnsearch.Show();
                    MessageBox.Show("Please Insert A Valid Staff Name");
                }
                else
                {

                    WCSA_Entity_Classes.Staff srcStaf = new StaffInfoPresenter().checkStaffDetails(textBox_search.Text);
                    if (srcStaf != null)
                    {
                        textBoxName.Text = srcStaf.Name;
                        textBoxName.Enabled = false;
                        textBoxMail.Text = srcStaf.Mail;
                        textBoxAddress.Text = srcStaf.Phone;
                        textBoxPhone.Text = srcStaf.Address;
                        textBoxNickName.Text = srcStaf.NickName;
                        textBoxPassword.Text = srcStaf.Password;
                        srcStaf = null;
                    }
                    else if (srcStaf == null)
                    {
                        disable();
                        groupBox2.Hide();
                        textBox_search.Show();
                        btnsearch.Show();
                        MessageBox.Show("Not Found");

                    }
                }
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
            refresh();

            //groupBox2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>() {
            //new Utility_Classes.Staff(StaffName,StaffMail, StaffPhone,StaffAddress, StaffNickname,StaffPassword)};
            if (str == "Matched")
            {
                new StaffInfoPresenter().Add(textBoxName.Text, textBoxMail.Text, textBoxPhone.Text,
                                        textBoxAddress.Text, textBoxNickName.Text, textBoxPassword.Text);
                MessageBox.Show("Successfull");
                groupBox2.Hide();
            }

            else
            {
                MessageBox.Show("Error");
                groupBox2.Show();
            }
            
            
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
            groupBox2.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            refrence.Show();
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                labelComent.Text = "Passwprd Matched";
                str = "Matched";
            }
            else
            {
                labelComent.Text = "Passwprd Not Matched";
                str = "";           }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNickName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
