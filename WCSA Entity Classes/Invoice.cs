using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class Invoice
    {
        uint invoiceNumber;
        string date;
        uint salesAmount;
        string admin;

        public Invoice(uint invoiceNumber,string date, uint salesAmount , string admin)
        {
            this.invoiceNumber = invoiceNumber;
            this.date = date;
            this.salesAmount = salesAmount;
            this.admin = admin;
        }

        public Invoice()
        {
            this.invoiceNumber = 0;
            this.date = "";
            this.salesAmount = 0;
            this.admin = "";
        }

        public uint InvoiceNumber
        {
            set
            {
                invoiceNumber = value;

            }
            get
            {
                return invoiceNumber;
            }
        }

        public string Date
        {
            set
            {
                date = value;

            }
            get
            {
                return date;
            }
        }

        public uint SalesAmount
        {
            set
            {
                salesAmount = value;

            }
            get
            {
                return salesAmount;
            }
        }

        public string Admin
        {
            set
            {
                admin = value;

            }
            get
            {
                return admin;
            }
        }
    }
}
