using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;
using WCSA_Entity_Classes;

namespace WCSA_Service_Classes
{
    public class RePrintPresenter
    {
        public RePrintPresenter()
        {

        }

        public List<Invoice> returnInvoiceList()
        {
            return new InvoiceDataSource().returnInvoiceList();
        }

        public Invoice getAnInvoice(uint invoiceNumber)
        {
            return new InvoiceDataSource().returnInvoiceNumber(invoiceNumber);
        }

    }
}
