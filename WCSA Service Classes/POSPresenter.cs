using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;
using System.IO;
using System.Diagnostics;

using iTextSharp.text;
using iTextSharp.text.pdf;

using WCSA_Factory_Layer;


namespace WCSA_Service_Classes
{
    public class POSPresenter
    {
        

        static List<WCSA_Entity_Classes.Product> purchaseList = new List<WCSA_Entity_Classes.Product>();
        static double totalCost;
        //static uint number=1000000;

        public POSPresenter()
        {
           
        }

        public double totalshopingAmount
        {
            get { return totalCost; }
        }

        //This method is for returning an item to the UI
        public WCSA_Entity_Classes.Product returnProductDetails(string code)
        {
            ProductDataSource pds = new ProductDataSource();
            return pds.ReturnAnItem(code);
        }


        /*
        Item addition to static list starts here
        */
        public double addItemToInvoice(string productCode, double price, uint quantity, double vat)
        {
            ProductDataSource pds = new ProductDataSource();
            WCSA_Entity_Classes.Product tempP = pds.ReturnAnItem(productCode);
            pds.ModifyItemInAccordanceWithInvoice(productCode, quantity);
            purchaseList.Add(new Product(productCode, tempP.ProductName, price * quantity, quantity));

            //Console.WriteLine("price = {0}  ||  quantity = {1}", price, quantity);

            //Update total cost
            totalCost += (price * quantity);
            //Console.WriteLine("totalCost = " + totalCost);

            return (totalCost + ((totalCost * vat) / 100));
        }
        /*
        Item addition to static list ends here
        */


        //Method for removing an item from list
        public void removeItemFromInvoice(string pcode)
        {
            purchaseList.RemoveAll(purchaseList => purchaseList.ProductCode.Equals(pcode));
        }


        //Method to be called in case of new transaction
        public void newTransaction()
        {
            //++number;
            
            purchaseList.Clear();
            totalCost = 0;
        }

        //Method to return the entire purchase list
        public List<WCSA_Entity_Classes.Product> getInvoiceItemsList()
        {
            return purchaseList;
        }


        /*
        PDF generation code starts here
        */
        public uint generateInvoice( double vat,double totalprice , string date,string time,string admin,string paid,string moneyreturn)
        {
            Document myDocument = new Document(PageSize.A4.Rotate());

            InvoiceFactory ifc = new InvoiceFactory();
            uint invNumber = ifc.makeNewTransactionNumber();
            Invoice inv = new Invoice();



            try
            {

                // step 2:
                // Now create a writer that listens to this doucment and writes the document to desired Stream.
                string documentPath = @"C:\\Users\\ahmed\\Desktop\\PDF\\";
                string filename = invNumber + ".pdf";
                string documentFullPath = documentPath + filename;


                string invPath = "C:\\Users\\ahmed\\Desktop\\PDF\\";
                string path = invPath + invNumber + ".pdf";
                inv.InvoiceNumber = invNumber;
                inv.Date = date;
                inv.SalesAmount = totalprice;
                inv.Admin = admin;
                inv.Path=invPath;


                PdfWriter.GetInstance(myDocument, new FileStream(documentFullPath, FileMode.Create));

                // step 3:  Open the document now using
                myDocument.Open();
                // step 4: Now add some contents to the document
                
                //myDocument.Add(new Paragraph("                           time: "));
                myDocument.Add(new Paragraph("                Welcome            "));
                myDocument.Add(new Paragraph("         Wapon Shop Management            "));
                myDocument.Add(new Paragraph("               Nikunjo-2           "));
                myDocument.Add(new Paragraph("                Road : 11            "));
                myDocument.Add(new Paragraph("               House : 2A            "));
                myDocument.Add(new Paragraph("               Contact Number : "+"012863772"+"            "));

                myDocument.Add(new Paragraph("      Invoice Number = "+ invNumber));
                myDocument.Add(new Paragraph("                          "+ date + " " + time));
                myDocument.Add(new Paragraph("                   "));
                myDocument.Add(new Paragraph("VAT percentage = " + vat));
                myDocument.Add(new Paragraph("Name         Quantity           Price"));

                foreach (Product P in purchaseList)
                {
                    string printstr = string.Format("{0}            {1}           {2}\n", P.ProductName,P.Quantity,P.Price);
                    myDocument.Add(new Paragraph(printstr));
                }
                myDocument.Add(new Paragraph("           total cost :  "  +totalCost) );
                myDocument.Add(new Paragraph("           Cash Paid :"+paid ));
                myDocument.Add(new Paragraph("           cash return : "+moneyreturn ));

                myDocument.Add(new Paragraph("Cashair : "+admin+""));

                myDocument.Add(new Paragraph("            Thank you For Your Visit           "));
                myDocument.Add(new Paragraph("                 Have A Nice Day              "));


            }
            catch (DocumentException de)
            {
                Console.Error.WriteLine(de.Message);
            }
            catch (IOException ioe)
            {
                Console.Error.WriteLine(ioe.Message);
            }

            // step 5: Remember to close the documnet

            myDocument.Close();

            InvoiceDataSource ids = new InvoiceDataSource();
            ids.AddInvoiceNumber(inv);
            return invNumber;
        }
        /*
        PDF generation code ends here
        */
        public uint TransactionNumber()
        {
            return new InvoiceFactory().getCurrentTransactionNumber();
            
        }

        public uint getCurrentInvoiceNumber()
        {
            return new InvoiceFactory().getCurrentTransactionNumber();
        }


    }
}
