using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class Product
    {
        string productCode;
        string productName;
        double price;
        uint quantity;

       // string searchCode;

        public Product(string productCode, string productName, double price, uint quantity)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }

        public Product()
        {
            this.productCode = null;
            this.productName = null;
            this.price = 0;
            this.quantity = 0;
        }

        public string ProductCode
        {
            set
            {
                productCode = value;
            }
            get { return productCode; }
        }
        public string ProductName
        {
            set
            {
                productName = value;
            }
            get { return productName; }
        }
        public double Price
        {
            set
            {
                price = value;
            }
            get { return price; }
        }
        public uint Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        //public string SearchCode
        //{
        //    set
        //    {
        //        //searchCode = textSearch.Text;
        //    }
        //    get { return searchCode; }
        //}

    }
}
