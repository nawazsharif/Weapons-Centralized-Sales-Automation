using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Weapon_shop.Utility_Classes
{
    public class Product
    {
        string productCode;
        string productName;
        double price;
        uint quantity;
        Image picture;
        string searchCode;

        public Product(string productCode, string productName, double price, uint quantity, Image picture)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.picture = picture;
        }

        public Product(string productCode, string productName, double price, uint quantity)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
            this.picture = null;
        }

        public Product()
        {
            this.productCode = null;
            this.productName = null;
            this.price = 0;
            this.quantity = 0;
            this.picture = null;
        }

        public string ProductCode
        {
            set
            {
             
            }
            get { return productCode; }
        }
        public string ProductName
        {
            set
            {
                //name = value;
            }
            get { return productName; }
        }
        public double Price
        {
            set
            {
                //price = value;
            }
            get { return price ; }
        }
        public uint Quantity
        {
            set
            {
               // quantity = value;
            }
            get { return quantity; }
        }
        public string SearchCode
        {
            set
            {
                //searchCode = textSearch.Text;
            }
            get { return searchCode; }
        }




    }
}
