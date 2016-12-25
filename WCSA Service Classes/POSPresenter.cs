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

namespace WCSA_Service_Classes
{
    public class POSPresenter
    {
        

        static List<WCSA_Entity_Classes.Product> purchaseList = new List<WCSA_Entity_Classes.Product>();
        static double totalCost;
        static uint number=1000000;

        public POSPresenter()
        {

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
            number++;
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
        public bool generateInvoice(uint invoiceNumber , double vat)
        {
            Document myDocument = new Document(PageSize.A4.Rotate());

            try
            {

                // step 2:
                // Now create a writer that listens to this doucment and writes the document to desired Stream.
                string documentPath = @"C:\\Users\\ahmed\\Desktop\\PDF\\";
                string filename = invoiceNumber + ".pdf";
                string documentFullPath = documentPath + filename;

                PdfWriter.GetInstance(myDocument, new FileStream(documentFullPath, FileMode.Create));

                // step 3:  Open the document now using
                myDocument.Open();
                // step 4: Now add some contents to the document
                myDocument.Add(new Paragraph("                Welcome            "));
                myDocument.Add(new Paragraph("         Wapon Shop Management            "));
                myDocument.Add(new Paragraph("               Nikunjo-2            "));
                myDocument.Add(new Paragraph("                Road : 11            "));
                myDocument.Add(new Paragraph("               House : 2A            "));
                myDocument.Add(new Paragraph("      Invoice Number = "+invoiceNumber));
                myDocument.Add(new Paragraph("                   "));
                myDocument.Add(new Paragraph("VAT percentage = " + vat));
                myDocument.Add(new Paragraph("Name         Quantity           Price"));

                foreach (Product P in purchaseList)
                {
                    string printstr = string.Format("{0}         {1}           {2}\n",P.ProductName,P.Quantity,P.Price);
                    myDocument.Add(new Paragraph(printstr));
                }
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

            return true;
        }
        /*
        PDF generation code ends here
        */
        public string TransactionNumber()
        {
  
            return number.ToString();
            
        }


    }
}
