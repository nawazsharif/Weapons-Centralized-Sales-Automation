using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Presenter_Classes
{
    public class POSPresenter
    {
        static List<Utility_Classes.Product> purchaseList = new List<Utility_Classes.Product>();

        string barCode;
        string productCode;
        string productname;
        double unitprice;
        uint quantity;
        double totalPrice;

        uint invoiceTotalItems;
        double invoiceVAT;
        double invoiceTotalCost;

        double vatValue;


        public POSPresenter(POS POSPage)
        {
            barCode = POSPage.BarCode;
            productCode = POSPage.newProductName;
            productname = POSPage.ProductName;
            //quantity = POSPage.Quantity;
            unitprice = POSPage.UnitPrice;
            //quantity = POSPage.Quantity;
            totalPrice = unitprice * quantity;

            invoiceTotalItems = POSPage.InvoiceTotalItems;
            invoiceVAT = POSPage.InvoiceTotalVAT;
            invoiceTotalCost = POSPage.InvoiceTotalPrice;

            vatValue = invoiceTotalCost * invoiceVAT;
        }

        //public void Add()
        //{
        //    Weapon_shop.Data_Source.ProductDataSource pds = new Data_Source.ProductDataSource();
        //    pds.AddToList(new Utility_Classes.Product(code, name, price, quantity));
        //}

        public bool checkProductDetails()
        {
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(productCode);
            if (currentProduct == null) return false;
            else
            {
                productCode = currentProduct.ProductCode;
                productname = currentProduct.ProductName;
                totalPrice = currentProduct.Price;
                quantity = currentProduct.Quantity;
                return true;
            }
        }
        public Utility_Classes.Product checkProductDetails(string code)
        {
            Data_Source.ProductDataSource pds = new Data_Source.ProductDataSource();
            return pds.ReturnAnItem(code);
        }



        //This method is for calling from Browse method ???
        public Utility_Classes.Product ReturnItemDetail()
        {
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(productCode);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        //This method is for calling from Search method 
        public Utility_Classes.Product ReturnSingleItemDetail()
        {
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(productCode);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        public List<Utility_Classes.Product> fetchProductList()
        {
            List<Utility_Classes.Product> productList = new List<Utility_Classes.Product>();
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            sds.returnEntireList(productList);

            return productList;
        }
    }

}