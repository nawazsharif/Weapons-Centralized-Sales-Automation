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
    public partial class ManagerInfo : Form
    {

        static string managerPassword = "Admin";

        public ManagerInfo()
        {
            InitializeComponent();
        }

        public string ManagerPassword
        {
            get
            {
                return managerPassword;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SupplierInfoForm sinfo = new SupplierInfoForm(this);
            this.Hide();
            sinfo.Show();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BankAccountForm bf = new BankAccountForm(this);
            bf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
