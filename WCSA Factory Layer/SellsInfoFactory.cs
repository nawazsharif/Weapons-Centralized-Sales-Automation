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





    }
}
