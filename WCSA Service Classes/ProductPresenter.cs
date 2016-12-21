using System.Collections.Generic;
using WCSA_Data_Source_Layer;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;

namespace WCSA_Service_Classes
{
    public class ProductPresenter
    {
        public ProductPresenter()
        {
        }

        public void Add(string code, string name, double price, uint quantity)
        {
            ProductDataSource pds = new ProductDataSource();
            pds.AddToList(new WCSA_Entity_Classes.Product(code, name,price,quantity));
        }

        public WCSA_Entity_Classes.Product checkProductDetails(string code)
        {
            ProductDataSource pds = new ProductDataSource();
            return pds.ReturnAnItem(code);
        }



        //This method is for calling from Browse method ???
        public WCSA_Entity_Classes.Product ReturnItemDetail(string code)
        {
            ProductDataSource sds = new ProductDataSource();
            WCSA_Entity_Classes.Product currentProduct = sds.ReturnAnItem(code);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        //This method is for calling from Search method 
        public WCSA_Entity_Classes.Product ReturnSingleItemDetail(string searchCode)
        {
            ProductDataSource sds = new ProductDataSource();
            WCSA_Entity_Classes.Product currentProduct = sds.ReturnAnItem(searchCode);
            if (currentProduct == null) return null;
            else return currentProduct;
        }

        public List<WCSA_Entity_Classes.Product> fetchProductList()
        {
            List<WCSA_Entity_Classes.Product> productList = new List<WCSA_Entity_Classes.Product>();
            ProductDataSource sds = new ProductDataSource();
            sds.returnEntireList(productList);

            return productList;
        }
    }
}
