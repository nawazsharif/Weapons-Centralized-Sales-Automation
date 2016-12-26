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
    public partial class VatForm : Form
    {
        static public double vat=0;

        public double VAT
        {
            set
            {
                vat = value;
            }
            get
            {
                return vat;
            }
        }

        public VatForm(MainForm mf)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vat = Convert.ToDouble(textBox1.Text);
            this.Close();
        }
    }
}
