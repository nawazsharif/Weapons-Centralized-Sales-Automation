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
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Equals(new ManagerInfo().ManagerPassword))
            {
                this.Hide();
                ManagerInfo minfo = new ManagerInfo();
                minfo.Show();
            }
            
        }
    }
}
