using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;

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
                /*
                Database query code goes in here
                */

                selfReference = this;
            }
        }

        public void AddInvoiceNumber()
        {

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
