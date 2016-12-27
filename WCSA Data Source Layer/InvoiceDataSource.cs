using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using DataConnection;

namespace WCSA_Data_Source_Layer
{
    

    public class InvoiceDataSource
    {
        static List<Invoice> list = new List<Invoice>();

        static InvoiceDataSource selfReference;

        public InvoiceDataSource()
        {
            if(selfReference == null)
            {
                //Execute query to fetch data from database
                List<Invoice> staffList = new InvoiceDataAccess().GetAll();
                foreach (Invoice stf in staffList)
                {
                    list.Add(stf);
                }
                list = staffList;

                selfReference = this;
            }
        }

        public void AddInvoiceNumber(Invoice inv)
        {
            list.Add(inv);
            new InvoiceDataAccess().Add(inv);
        }

        public Invoice returnInvoiceNumber(uint invNumber)
        {
            return list.Find(list => list.InvoiceNumber==invNumber);
        }

        public List<Invoice> returnInvoiceList()
        {
            return new List<Invoice>(list);
        }
    }
}
