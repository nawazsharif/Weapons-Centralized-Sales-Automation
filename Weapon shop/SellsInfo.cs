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

            dateTimePicker1.Text = DateTime.Today.ToString();
            dateTimePicker2.Text = DateTime.Today.ToString();

            chartSalesInfo.Hide();


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
            Console.WriteLine("Combobox text changed function called");
            if(comboBox1.Text.Equals("All-Sorted- Sales Person"))
            {
                Console.WriteLine("Entering first if :: Sorted by sales person");
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByStaffName();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            else if (comboBox1.Text.Equals("All-Sorted-Invoice Number"))
            {
                Console.WriteLine("Entering first else if :: sorted by invoice number");
                List<Invoice> tempList = new SellsInfoPresenter().returnInvoiceListOrderByInvoiceNumber();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = tempList;
                dataGridView1.Show();
            }
            else if (comboBox1.Text.Equals("Daily Report") )
            {
                Console.WriteLine("Entering second else if :: daily report");

                Console.WriteLine("Date on date time picker  : {0}", dateTimePicker1.Text.ToString());
                itemListTuple<double, String> temp = new SellsInfoPresenter().getDailyRecord(dateTimePicker1.Text.ToString());
                List<Tuple<double, String>> templList = temp.getEntireList();

                chartSalesInfo.Series["Series1"].ChartType = SeriesChartType.Column;

                int dataIndex = 1;

                foreach(Tuple<double,string> t in templList)
                {
                    chartSalesInfo.Series["Series1"].Points.AddXY(dataIndex, t.Item1);
                    //Console.WriteLine("Final(In SalesInfo)  X : {0}    Y : {1}",t.Item1,dataIndex);
                    dataIndex++;
                }


                chartSalesInfo.Series["Series1"].ChartArea = "ChartArea1";
                chartSalesInfo.Show();
            }
            else if (comboBox1.Text.Equals("Weekly Report"))
            {
                Console.WriteLine("Entering third else if :: weekly report");

                itemListTuple<double, String> temp = new SellsInfoPresenter().getWeeklyRecord(dateTimePicker1.Text.ToString());
                List<Tuple<double, String>> templList = temp.getEntireList();

                chartSalesInfo.Series["Series1"].ChartType = SeriesChartType.Stock;

                int dataIndex = 1;

                foreach (Tuple<double, string> t in templList)
                {
                    chartSalesInfo.Series["Series1"].Points.AddXY(dataIndex, t.Item1);
                    //Console.WriteLine("Final(In SalesInfo)  X : {0}    Y : {1}",t.Item1,dataIndex);
                    dataIndex++;
                }


                chartSalesInfo.Series["Series1"].ChartArea = "ChartArea1";
                chartSalesInfo.Show();
            }
            else if (comboBox1.Text.Equals("Mothly Report"))
            {
                Console.WriteLine("Entering fourth else if :: monthly report");

                itemListTuple<double, String> temp = new SellsInfoPresenter().getMonthlyRecord(dateTimePicker1.Text.ToString());
                List<Tuple<double, String>> templList = temp.getEntireList();

                chartSalesInfo.Series["Series1"].ChartType = SeriesChartType.Stock;

                int dataIndex = 1;

                foreach (Tuple<double, string> t in templList)
                {
                    chartSalesInfo.Series["Series1"].Points.AddXY(dataIndex, t.Item1);
                    dataIndex++;
                }


                chartSalesInfo.Series["Series1"].ChartArea = "ChartArea1";
                chartSalesInfo.Show();
            }
            else if(comboBox1.Text.Equals("Date Range"))
            {
                Console.WriteLine("Entering fifth else if :: time period");

                //dateTimePicker2.Show();

                itemListTuple<double, DateTime> temp = new SellsInfoPresenter().getDayRangeRecord(dateTimePicker1.Text.ToString(),
                    dateTimePicker2.Text.ToString());
                List<Tuple<double, DateTime>> templList = temp.getEntireList();

                chartSalesInfo.Series["Series1"].ChartType = SeriesChartType.Stock;

                int dataIndex = 1;

                foreach (Tuple<double, DateTime> t in templList)
                {
                    chartSalesInfo.Series["Series1"].Points.AddXY(dataIndex, t.Item1);
                    //Console.WriteLine("Final(In SalesInfo)  X : {0}    Y : {1}",t.Item1,dataIndex);
                    dataIndex++;
                }


                chartSalesInfo.Series["Series1"].ChartArea = "ChartArea1";
                chartSalesInfo.Show();
            }

        }

        private void grouper1_Load(object sender, EventArgs e)
        {

        }
    }
}
