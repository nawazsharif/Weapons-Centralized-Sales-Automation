using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCSA_Entity_Classes;
using WCSA_Service_Classes;

namespace Weapon_shop
{
    public partial class AddCustomerForm : Form
    {
        POS refrence;
        public AddCustomerForm()
        {
            InitializeComponent();
            btnOk.Hide();
        }
        public AddCustomerForm(POS ps)
        {
            InitializeComponent();
            btnOk.Hide();
            refrence = ps;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Customer cs = new CustomerPresenter().checkcustomerDetails(textBox1.Text);
            if (cs != null)
            {
                textNid.Enabled = false;
                textName.Text = cs.Name;
                textMail.Text = cs.Mail;
                textPhone.Text = cs.Phone;
                textAddress.Text = cs.Address;
                textNid.Text = cs.NID;
                textLicence.Text = cs.License;
                btnAdd.Hide();
                btnOk.Show();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CustomerPresenter().Add(textName.Text, textMail.Text, textPhone.Text, textAddress.Text, textNid.Text, textLicence.Text);
            this.Hide();
            refrence.customernid = textNid.Text;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            new CustomerPresenter().modifyCustomerDetails (textName.Text, textMail.Text, textPhone.Text, textAddress.Text, textNid.Text, textLicence.Text);
            this.Hide();
            refrence.customernid = textNid.Text;
            MessageBox.Show("Add Successfully");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
