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
using System.Data.SqlClient;
using System.Data.Sql;
using DataConnection;

namespace Weapon_shop
{
    public partial class Staff : Form
    {
        int rowIndex = 0;
        // string query = "Select * From STAFF";
        
        public int chk ;
        public string str;
        MainForm refrence;
        public void disable()
        {
            textBox_search.Hide();
            
            groupBox2.Hide();
            dataGridView1.Hide();
        }
        public void refresh()
        {
            labelchk.Text = null;
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
            //this.ControlBox = false;
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
            btn_staff_add.Show();
            btnOk.Hide();
            refresh();
            labelchk.Text = "";
            textBoxName.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            disable();
            chk = 3;
            
            textBox_search.Show();
            refresh();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            // Show data
            disable();
            chk = 1;
            dataGridView1.Show();
            textBox_search.Show();
            
            dataGridView1.DataSource = new StaffInfoPresenter().fetchStaffList();
            

            //groupBox2.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>() {
            //new Utility_Classes.Staff(StaffName,StaffMail, StaffPhone,StaffAddress, StaffNickname,StaffPassword)};
            if (textBoxAddress.Text == "" || textBoxMail.Text == "" || textBoxName.Text == "" || textBoxNickName.Text == "" || textBoxPhone.Text == "" || textBoxConfirmPassword.Text == "" || textBoxPassword.Text == "")
            { MessageBox.Show("Fill up all Field"); }
            else {
                //MessageBox.Show(new StaffInfoPresenter().returnMatching(textBoxName.Text).ToString()); 
                if (new StaffInfoPresenter().returnMatching(textBoxName.Text) == 1)
                {
                    labelchk.Text = "already exist";
                }
                else
                {
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
            //if (new StaffInfoPresenter().returnMatching(textBoxName.Text) == 1) { labelchk.Text = "already exist"; }
            
            labelchk.Text = "";
            if (textBoxName.Text == "") { labelchk.Text = ""; }
            
            //textBoxName.Text = textBoxName.Text.Trim();
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
            dataGridView1.DataSource = new StaffInfoPresenter().fetchStaffList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "" || textBoxMail.Text == "" || textBoxName.Text == "" || textBoxNickName.Text == "" || textBoxPhone.Text == "" || textBoxPassword.Text == "")
            { MessageBox.Show("Fill up all Field"); }
            else
            {

                new StaffInfoPresenter().modifyStaffDetails(textBoxName.Text, textBoxMail.Text, textBoxPhone.Text,
                                            textBoxAddress.Text, textBoxNickName.Text, textBoxPassword.Text);
                MessageBox.Show("Edit Successfull");
                groupBox2.Hide();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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
                str = "";
            }
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            disable();
            
        }
        

       

        private void grouper1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseUp_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[2];
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
                new StaffInfoPresenter().DeleteStaff(dataGridView1.CurrentCell.Value.ToString());
                dataGridView1.DataSource= new StaffInfoPresenter().fetchStaffList();
            }
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textBox_search_EnterKeyPressed(this, new EventArgs());
            }
        }

        private void textBox_search_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void textBox_search_EnterKeyPressed(object sender, EventArgs e)
        {
            if (textBox_search.Text == "") { dataGridView1.DataSource = new StaffInfoPresenter().fetchStaffList(); }
            else
            {
                disable();
                // MessageBox.Show(Convert.ToString(chk));


                /*
                Code of search button for the tab "Show All" starts here
                */
                if (chk == 1)
                {
                    disable();
                    textBox_search.Show();
                    
                    groupBox2.Hide();
                    dataGridView1.DataSource = null;
                    //List<WCSA_Entity_Classes.Staff> stflist = new List<WCSA_Entity_Classes.Staff>();
                    //stflist.Add(new StaffInfoPresenter().checkStaffDetails(textBox_search.Text));
                    //foreach (WCSA_Entity_Classes.Staff st in stflist)
                    //{
                    //    Console.WriteLine("Staff name : " + st.Name);
                    //}
                    dataGridView1.DataSource = new StaffInfoPresenter().returnMatchingStaffList(textBox_search.Text);
                    dataGridView1.Show();
                }
                /*
                Code of search button for the tab "Show All" ends here
                */

                else if (chk == 0)// add button
                {
                    textBoxName.Enabled = true;
                    textBox_search.Hide();
                    
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
                    
                    groupBox2.Show();
                    btn_staff_add.Hide();
                    textBoxConfirmPassword.Hide();
                    label9.Hide();
                    btnOk.Show();
                    if (textBox_search.Text == "")
                    {
                        disable();
                        groupBox2.Hide();
                        textBox_search.Show();
                        
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
                          
                            MessageBox.Show("Not Found");

                        }
                    }
                }
            }
        }
    }
}
