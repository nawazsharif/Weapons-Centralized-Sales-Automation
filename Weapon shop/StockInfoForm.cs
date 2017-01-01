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
    public partial class StockInfoForm : Form
    {
        public StockInfoForm()
        {
            InitializeComponent();
        }

        private void StockInfoForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = new ProductPresenter().fetchProductList();
        }
    }
}
