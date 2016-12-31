using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using WCSA_Data_Source_Layer;

namespace WCSA_Factory_Layer
{

    public class SellsInfoFactory
    {
        public itemListTuple<double, string> getOneDayRecord(string day)
        {
            itemListTuple<double, string> tempTuple = new itemListTuple<double, string>();

            List<Invoice> tempInvoiceList = new InvoiceDataSource().returnInvoiceList();

            foreach(Invoice inv in tempInvoiceList)
            {
                if (inv.Date.Equals(day, StringComparison.OrdinalIgnoreCase))
                {
                    tempTuple.Add(inv.SalesAmount, inv.Admin);
                } 
            }
            return tempTuple;
        }

        public itemListTuple<double, string> getWeeklyRecord(string startDay)
        {

            double[] arr = new double[7];
            int arrIndex = 0;

            string date = startDay;
            DateTime datevalue = (Convert.ToDateTime(date.ToString()));

            String dy = datevalue.Day.ToString();

            DateTime dayStart = datevalue;
            DateTime dayLimit = datevalue.AddDays(7);

            itemListTuple<double, string> tempTuple = new itemListTuple<double, string>();

            List<Invoice> tempInvoiceList = new InvoiceDataSource().returnInvoiceList();

            foreach (Invoice inv in tempInvoiceList)
            {
                DateTime cdate = (Convert.ToDateTime(inv.Date.ToString()));

                if (cdate > dayLimit) break;
                else if ((cdate.Day - dayStart.Day) > arrIndex) arrIndex++;
                else if ((cdate.Day - dayStart.Day) == arrIndex)
                {
                    arr[arrIndex] += inv.SalesAmount;
                }
            }

            for(int i=0; i<7; i++)
            {
                tempTuple.Add(arr[i], "Day : " + (i + 1));
            }
            return tempTuple;
        }

        public itemListTuple<double, string> getMonthlyRecord(string startDay)
        {

            double[] arr = new double[30];
            int arrIndex = 0;

            string date = startDay;
            DateTime datevalue = (Convert.ToDateTime(date.ToString()));

            String dy = datevalue.Day.ToString();

            DateTime dayStart = datevalue;
            DateTime dayLimit = datevalue.AddDays(30);

            itemListTuple<double, string> tempTuple = new itemListTuple<double, string>();

            List<Invoice> tempInvoiceList = new InvoiceDataSource().returnInvoiceList();

            foreach (Invoice inv in tempInvoiceList)
            {
                DateTime cdate = (Convert.ToDateTime(inv.Date.ToString()));

                if (cdate > dayLimit) break;
                else if ((cdate.Day - dayStart.Day) > arrIndex) arrIndex++;
                else if ((cdate.Day - dayStart.Day) == arrIndex)
                {
                    arr[arrIndex] += inv.SalesAmount;
                }
            }

            for (int i = 0; i < 30; i++)
            {
                tempTuple.Add(arr[i], "Day : " + (i + 1));
            }
            return tempTuple;
        }

        public itemListTuple<double, DateTime> getDayRangeRecord(string startDay, string endDay)
        {
            double amt=0;

            DateTime currentDay;
            DateTime dayStart = (Convert.ToDateTime(startDay.ToString()));
            DateTime dayLimit = (Convert.ToDateTime(endDay.ToString()));

            itemListTuple<double, DateTime> tempTuple = new itemListTuple<double, DateTime>();

            List<Invoice> tempInvoiceList = new InvoiceDataSource().returnInvoiceList();

            currentDay = dayStart;
            foreach (Invoice inv in tempInvoiceList)
            {
                DateTime invoiceDate = (Convert.ToDateTime(inv.Date));
                if (invoiceDate > dayLimit) break;
                else if(invoiceDate == currentDay)
                {
                    amt += inv.SalesAmount;
                }
                else if(invoiceDate > currentDay)
                {
                    tempTuple.Add(amt, currentDay);
                    currentDay = currentDay.AddDays(1);
                }
            }

            return tempTuple;
        }
    }
}
