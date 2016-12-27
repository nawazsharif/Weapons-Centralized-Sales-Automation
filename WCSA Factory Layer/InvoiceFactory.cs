using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Factory_Layer;
using WCSA_Data_Source_Layer;
using WCSA_Entity_Classes;

namespace WCSA_Factory_Layer
{
    public class InvoiceFactory
    {
        static uint largestInvoicNumber = 1000;

        public InvoiceFactory()
        {
            if(largestInvoicNumber == 1000)
            {
                calculateLargestTransactionNumber();
            }
        }

        public void calculateLargestTransactionNumber()
        {
            //Step 1 : Fetch the list
            InvoiceDataSource ids = new InvoiceDataSource();
            List<Invoice> tempList = ids.returnInvoiceList();

            //Step 2 : Iterate through the list and record the largest number
            foreach(Invoice inv in tempList)
            {
                if (inv.InvoiceNumber > largestInvoicNumber) largestInvoicNumber = inv.InvoiceNumber;
            }

            //Step 3 : end of iteration. set the max value to max found value
            //Done
        }

        public uint makeNewTransactionNumber (){
            largestInvoicNumber++;
            return largestInvoicNumber;
        }

        public uint getCurrentTransactionNumber()
        {
            return largestInvoicNumber;
        }

    }
}
