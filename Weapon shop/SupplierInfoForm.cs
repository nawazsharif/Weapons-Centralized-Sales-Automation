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
    public partial class SupplierInfoForm : Form
    {
        ManagerInfo reference;

        int chk;

        public SupplierInfoForm()
        {
            InitializeComponent();
            disable();
        }


        public SupplierInfoForm(ManagerInfo minfo)
        {
            InitializeComponent();
            disable();
            reference = minfo;

        }
        public void disable()
        {
            groupBox2.Hide();
            textSearch.Hide();
            btnSearch.Hide();
            dataGridView1.Hide();
            btnOk.Hide();
            labelX.Hide() ;
            labelchk.Text = "";

        }
        private void SupplierInfoForm_Load(object sender, EventArgs e)
        {

        }



        private void btn_S_Search_Click(object sender, EventArgs e)
        {
            disable();
            // MessageBox.Show(Convert.ToString(chk));

            if (chk == 1)
            {
                disable();
                textSearch.Show();
                btnSearch.Show();
                groupBox2.Hide();
                groupBox2.Hide();
                dataGridView1.Show();


            }
            else if (chk == 0)
            {
                groupBox2.Show();
                textSearch.Hide();
                btnSearch.Hide();
                //btnOk.Hide();


            }
            else
            {
                textSearch.Hide();
                groupBox2.Show();
                btnSearch.Hide();
                btn_staff_add.Hide();
                btnOk.Show();
                if (textSearch.Text == "")
                {
                    disable();
                    groupBox2.Hide();
                    textSearch.Show();
                    btnSearch.Show();
                    MessageBox.Show("Please Insert A Valid shop Name");
                }
                else
                {

                    WCSA_Entity_Classes.Supplier sup = new SupplierInfoPresenter().checkSupplierDetails(textSearch.Text);
                    if (sup != null)
                    {
                        texShopName.Text = sup.ShopName;
                        texMail.Text = sup.Mail;
                        texAddress.Text = sup.Address;
                        texContact.Text = sup.Contact;
                        texBank.Text = sup.BankAccount;
                        sup = null;
                    }
                    else if (sup == null)
                    {
                        disable();
                        groupBox2.Hide();
                        textSearch.Show();
                        btnSearch.Show();
                        MessageBox.Show("Not Found");

                    }
                }

            }
        }

        private void btn_staff_add_Click(object sender, EventArgs e)
        {
            if (textAccountHolderName.Text == "" || texMail.Text == "" || texContact.Text == "" || texBank.Text == "" || texAddress.Text == "" || texShopName.Text == "")
            {
                MessageBox.Show("Fill up all Field");
            }
            else
            {
                if (new SupplierInfoPresenter().returnMatching(texShopName.Text) == 1)
                {
                    labelchk.Text = "already exist";
                    labelX.Show();
                }
                else
                {
                    groupBox2.Hide();
                    new SupplierInfoPresenter().Add(texShopName.Text, texMail.Text, texAddress.Text, texContact.Text, texBank.Text, textAccountHolderName.Text);
                    MessageBox.Show("Successfull");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)//update button
        {
            disable();
            chk = 3;
            btnSearch.Show();
            textSearch.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)//Show all button
        {
            disable();
            chk = 1;
            dataGridView1.Show();
            textSearch.Show();
            btnSearch.Show();
            dataGridView1.DataSource = new SupplierInfoPresenter().fetchSupplierList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)// add button
        {
            disable();
            groupBox2.Show();
            btn_staff_add.Show();
            chk = 0;
            texShopName.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)//button Search
        {
            if (textSearch.Text == "") { }
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
                    textSearch.Show();
                    btnSearch.Show();
                    groupBox2.Hide();
                    dataGridView1.DataSource = null;
                    //List<WCSA_Entity_Classes.Staff> stflist = new List<WCSA_Entity_Classes.Staff>();
                    //stflist.Add(new StaffInfoPresenter().checkStaffDetails(textBox_search.Text));
                    //foreach (WCSA_Entity_Classes.Staff st in stflist)
                    //{
                    //    Console.WriteLine("Staff name : " + st.Name);
                    //}
                    dataGridView1.DataSource = new StaffInfoPresenter().returnMatchingStaffList(textSearch.Text);
                    dataGridView1.Show();
                }
                /*
                Code of search button for the tab "Show All" ends here
                */

                else if (chk == 0)// add button
                {
                    texShopName.Enabled = true;
                    textSearch.Hide();
                    btnSearch.Hide();
                    groupBox2.Show();
                    

                }
                else//update button
                {
                    textSearch.Hide();
                    btnSearch.Hide();
                    groupBox2.Show();
                    btn_staff_add.Hide();
                    
                    btnOk.Show();
                    if (textSearch.Text == "")
                    {
                        disable();
                        groupBox2.Hide();
                        textSearch.Show();
                        btnSearch.Show();
                        MessageBox.Show("Please Insert A Valid Staff Name");
                    }
                    else
                    {

                        WCSA_Entity_Classes.Supplier srcStaf = new SupplierInfoPresenter().checkSupplierDetails(textSearch.Text);
                        if (srcStaf != null)
                        {
                            texShopName.Text = srcStaf.ShopName;
                            texShopName.Enabled = false;
                            texMail.Text = srcStaf.Mail;
                            texContact.Text = srcStaf.Contact;
                            texAddress.Text = srcStaf.Address;
                            texBank.Text = srcStaf.BankAccount;
                            textAccountHolderName.Text = srcStaf.AccountHolderName;
                            srcStaf = null;
                        }
                        else if (srcStaf == null)
                        {
                            disable();
                            groupBox2.Hide();
                            textSearch.Show();
                            btnSearch.Show();
                            MessageBox.Show("Not Found");

                        }
                    }
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            MessageBox.Show("Successfull");
            new SupplierInfoPresenter().Add(texShopName.Text, texMail.Text, texAddress.Text, texContact.Text, texBank.Text,textAccountHolderName.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }
    }



}