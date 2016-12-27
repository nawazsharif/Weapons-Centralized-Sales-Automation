using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataConnection
{
    public class InvoiceDataAccess
    {
        public int Add(WCSA_Entity_Classes.Invoice invoice)
        {
            string query = string.Format("INSERT INTO INVOICE (InvoiceNumber,Date,SellsAmount,Admin,Path) VALUES('{0}', '{1}', '{2}', '{3}','{4}')", invoice.InvoiceNumber,invoice.Date,invoice.SalesAmount,invoice.Admin,invoice.Path);
            Console.WriteLine("Inv DB query = " + query);
            Console.WriteLine("Invoice number in data access : " + invoice.InvoiceNumber);
            return DataAccess.ExecuteQuery(query);
        }

       

       

        public List<WCSA_Entity_Classes.Invoice> GetAll()
        {
            string query = "SELECT InvoiceNumber,Date,SellsAmount,Admin,Path FROM INVOICE";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Invoice invoice = null;
            List<WCSA_Entity_Classes.Invoice> invoiceList = new List<WCSA_Entity_Classes.Invoice>();
            while (reader.Read())
            {
                invoice = new WCSA_Entity_Classes.Invoice();
                invoice.InvoiceNumber = Convert.ToUInt32(reader["InvoiceNumber"].ToString());
                invoice.Date = reader["Date"].ToString();
                invoice.Path = reader["Path"].ToString();
                invoice.Admin = reader["Admin"].ToString();
                invoice.SalesAmount =Convert.ToDouble( reader["SellsAmount"].ToString());
               

                invoiceList.Add(invoice);
            }
            return invoiceList;
        }

       
    }
}
