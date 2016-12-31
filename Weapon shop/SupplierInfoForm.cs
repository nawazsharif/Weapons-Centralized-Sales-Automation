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
        int rowIndex;
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
           
            dataGridView1.Hide();
            btnOk.Hide();
            labelX.Hide() ;
            labelchk.Text = "";

        }
        public void refresh()
        {
            textSearch.Text = "";
            texAddress.Text = "";
            texAddress.Text = "";
            texContact.Text="";
            texMail.Text = "";
            texShopName.Text = "";
            textAccountHolderName.Text = "";
        }
        private void SupplierInfoForm_Load(object sender, EventArgs e)
        {

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
            refresh();
            disable();
            chk = 3;
            
            textSearch.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)//Show all button
        {
            refresh();
            disable();
            chk = 1;
            dataGridView1.Show();
            textSearch.Show();
           
            dataGridView1.DataSource = new SupplierInfoPresenter().fetchSupplierList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            reference.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)// add button
        {
            refresh();
            disable();
            groupBox2.Show();
            btn_staff_add.Show();
            chk = 0;
            texShopName.Enabled = true;
        }

        

        private void btnOk_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            MessageBox.Show("Edit Successfull");
            new SupplierInfoPresenter().Add(texShopName.Text, texMail.Text, texAddress.Text, texContact.Text, texBank.Text,textAccountHolderName.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close() ;
        }

        private void textSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textSearch_EnterKeyPressed(this, new EventArgs());
            }
        }
        private void textSearch_EnterKeyPressed(object sender, EventArgs e)
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
                    
                    groupBox2.Hide();
                    dataGridView1.DataSource = null;
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
                   
                    groupBox2.Show();


                }
                else//update button
                {
                    textSearch.Hide();
                   
                    groupBox2.Show();
                    btn_staff_add.Hide();

                    btnOk.Show();
                    if (textSearch.Text == "")
                    {
                        disable();
                        groupBox2.Hide();
                        textSearch.Show();
                        
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
                            
                            MessageBox.Show("Not Found");

                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            disable();
            refresh();
            groupBox2.Hide();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
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
                Supplier pp = new Supplier();
                // this.dataGridView1.Rows.RemoveAt(this.rowIndex);
                MessageBox.Show(dataGridView1.CurrentCell.Value.ToString());
                new SupplierInfoPresenter().DeleteSupplier(dataGridView1.CurrentCell.Value.ToString());
                dataGridView1.DataSource = new SupplierInfoPresenter().fetchSupplierList();
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (textSearch.Text == "")
            {
                dataGridView1.DataSource = new SupplierInfoPresenter().fetchSupplierList();
            }
        }
    }

}
