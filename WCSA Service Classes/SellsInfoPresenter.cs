using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using WCSA_Factory_Layer;
using WCSA_Data_Source_Layer;

namespace WCSA_Service_Classes
{
    public class SellsInfoPresenter
    {
        public SellsInfoPresenter()
        {

        }

        public List<Invoice> returnInvoiceList()
        {
            return new InvoiceDataSource().returnInvoiceList();
        }

        public List<Invoice> returnInvoiceListOrderByStaffName()
        {
            List <Invoice> lst =  new InvoiceDataSource().returnInvoiceList();
            List<Invoice> SortedList = lst.OrderBy(o => o.Admin).ToList();
            return SortedList;
        }

        public List<Invoice> returnInvoiceListOrderByInvoiceNumber()
        {
            List<Invoice> lst = new InvoiceDataSource().returnInvoiceList();
            List<Invoice> SortedList = lst.OrderBy(o => o.InvoiceNumber).ToList();
            return SortedList;
        }
    }
}
