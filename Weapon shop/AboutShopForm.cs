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
    public partial class AboutShopForm : Form
    {
        public AboutShopForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AboutForm.name = Name.Text;
            AboutForm.mail = Mail.Text;
            AboutForm.phone = Phone.Text;
            AboutForm.address = Address.Text;
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
