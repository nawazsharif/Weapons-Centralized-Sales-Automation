using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;

namespace WCSA_Service_Classes
{
    public class POSPresenter
    {
        

        static List<WCSA_Entity_Classes.Product> purchaseList = new List<WCSA_Entity_Classes.Product>();
        static double totalCost;

        public POSPresenter()
        {

        }

        //This method is for returning an item to the UI
        public WCSA_Entity_Classes.Product returnProductDetails(string code)
        {
            ProductDataSource pds = new ProductDataSource();
            return pds.ReturnAnItem(code);
        }

        //Method for adding item to static list
        public double addItemToInvoice(string productCode, double price, uint quantity, double vat)
        {
            ProductDataSource pds = new ProductDataSource();
            WCSA_Entity_Classes.Product tempP = pds.ReturnAnItem(productCode);
            purchaseList.Add(new Product(productCode, tempP.ProductName, price * quantity, quantity));

            //Console.WriteLine("price = {0}  ||  quantity = {1}", price, quantity);

            //Update total cost
            totalCost += (price * quantity);
            //Console.WriteLine("totalCost = " + totalCost);

            return (totalCost + ((totalCost * vat) / 100));
        }

        //Method for removing an item from list
        public void removeItemFromInvoice(string pcode)
        {
            purchaseList.RemoveAll(purchaseList => purchaseList.ProductCode.Equals(pcode));
        }


        //Method to be called in case of new transaction
        public void newTransaction()
        {
            purchaseList.Clear();
            totalCost = 0;
        }

        //Method to return the entire purchase list
        public List<WCSA_Entity_Classes.Product> getInvoiceItemsList()
        {
            return purchaseList;
        }

    }
}
