using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WCSA_Entity_Classes;
using WCSA_Service_Classes;

namespace Weapon_shop
{
    public partial class SellsInfo : Form
    {
        public SellsInfo()
        {
            InitializeComponent();
            dataGridView1.Hide();

            List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = tempList;
            dataGridView1.Show();

            dateTimePicker2.Hide();

            chartSalesInfo.Hide();

            /*
            chartSalesInfo.Series.Add("Series2");
            chartSalesInfo.Series["Series2"].Chart1512762871bal amarType = SeriesChartType.Column;
            chartSalesInfo.Series["Series2"].Points.AddY(20);
            chartSalesInfo.Series["Series2"].ChartArea = "ChartArea1";
            */

            this.WindowState = FormWindowState.Maximized;
        }

        private void SellsInfo_Load(object sender, EventArgs e)
        {
            
        }


        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("All-Sorted- Sales Person"))
            {
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByStaffName();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            else if (comboBox1.Text.Equals("All-Sorted-Invoice Number"))
            {
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByInvoiceNumber();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            else if (comboBox1.Text.Equals("Daily Report") )
            {
                chartSalesInfo.Series.Add("Series2");
                chartSalesInfo.Series["Series2"].ChartType = SeriesChartType.Column;
                //chartSalesInfo.Series["Series2"].Points.AddY(20);
                itemListTuple<double,String> temp =  new SellsInfoPresenter().getDailyRecord(dateTimePicker1.Text.ToString());



                chartSalesInfo.Series["Series2"].ChartArea = "ChartArea1";
                chartSalesInfo.Show();
            }
            else if (comboBox1.Text.Equals("Weekly Report"))
            {
                //chartSalesInfo.Series.Add("Series2");
                //chartSalesInfo.Series["Series2"].ChartType = SeriesChartType.FastLine;
                //chartSalesInfo.Series["Series2"].Points.AddY(20);
                //chartSalesInfo.Series["Series2"].ChartArea = "ChartArea1";
            }
            else if (comboBox1.Text.Equals("Mothly Report"))
            {
                //chartSalesInfo.Series.Add("Series2");
                //chartSalesInfo.Series["Series2"].ChartType = SeriesChartType.FastLine;
                //chartSalesInfo.Series["Series2"].Points.AddY(20);
                //chartSalesInfo.Series["Series2"].ChartArea = "ChartArea1";
            }
            else if(comboBox1.Text.Equals("Time Period"))
            {
                //chartSalesInfo.Series.Add("Series2");
                //chartSalesInfo.Series["Series2"].ChartType = SeriesChartType.FastLine;
                //chartSalesInfo.Series["Series2"].Points.AddY(20);
                //chartSalesInfo.Series["Series2"].ChartArea = "ChartArea1";
            }

        }
    }
}
