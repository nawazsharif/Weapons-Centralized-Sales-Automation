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
    public partial class AboutForm : Form
    {
        public static string name, mail, phone, address;

        public AboutForm()
        {
            InitializeComponent();
            label5.Text = name;
            label6.Text = mail;
            label7.Text = phone;
            label8.Text = address;

        }
    }
}
