using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Presenter_Classes
{
    public class ProductPresenter
    {
        string code;
        string name;
        double price;
        uint quantity;
        string searchCode;

        public ProductPresenter(Product ProductPage)
        {
            code = ProductPage.ProductCode;
            name = ProductPage.ProductName;
            price = ProductPage.Price;
            quantity = ProductPage.Quantity;
            searchCode = ProductPage.SearchCode;
        }

        public void Add()
        {
            Weapon_shop.Data_Source.ProductDataSource pds = new Data_Source.ProductDataSource();
            pds.AddToList(new Utility_Classes.Product(code,name,price,quantity));
        }

        public bool checkProductDetails()
        {
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(code);
            if (currentProduct == null) return false;
            else
            {
                code = currentProduct.ProductCode;
                name = currentProduct.ProductName;
                price = currentProduct.Price;
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
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(code);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        //This method is for calling from Search method 
        public Utility_Classes.Product ReturnSingleItemDetail()
        {
            Data_Source.ProductDataSource sds = new Data_Source.ProductDataSource();
            Utility_Classes.Product currentProduct = sds.ReturnAnItem(searchCode);
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
