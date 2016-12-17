using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Data_Source
{
    public class ProductDataSource
    {
        static List<Weapon_shop.Utility_Classes.Product> productList = new List<Weapon_shop.Utility_Classes.Product>()
        {
            new Utility_Classes.Product("1","Glock 17",5000,10)
        };

        public ProductDataSource()
        {
            PopulateFromDatabase();
        }

        void PopulateFromDatabase()
        {
            //Execute query and fill up the list here
        }

        public void AddToList(Weapon_shop.Utility_Classes.Product product)
        {
            productList.Add(product);
        }

        public void DeleteFromList(string code)
        {
            productList.RemoveAll(productList => productList.ProductCode.Equals(code));
        }

        public void ModifyList(Weapon_shop.Utility_Classes.Product product)
        {

            Weapon_shop.Utility_Classes.Product requiredProduct = productList.Find(productList => productList.ProductCode.Equals(product.ProductCode));
            int index = productList.IndexOf(requiredProduct);
            productList[index] = product;

        }

        public Weapon_shop.Utility_Classes.Product ReturnAnItem(string code)
        {
            return productList.Find(productList => productList.ProductCode.Equals(code));
        }

        public void UpdateDatabase(Product product)
        {
            //Execute SQL query to reflect changes
        }

        public void UpdateDatabase(List<Weapon_shop.Utility_Classes.Product> smallList, bool fullListUpdate)
        {
            if (fullListUpdate)
            {
                //Implement if necessary
                //Required once in a lifetime of the DB
            }
            else
            {
                //Implement if necessary
            }
        }

        //public void copyFullDataToThisList(List<Utility_Classes.Product> newProductList)
        //{
        //    //StaffDataSource.staffList.CopyTo(staffList);

        //    foreach (Utility_Classes.Product stf in newProductList)
        //    {
        //        newProductList.Add(stf);
        //    }
        //}

        static bool nidMatch(Weapon_shop.Utility_Classes.Product product, string nid)
        {
            return product.ProductCode.ToString().Equals(nid);
        }
        public void returnEntireList(List<Utility_Classes.Product> newProductList)
        {
            

            foreach (Utility_Classes.Product pro in productList)
            {
                newProductList.Add(pro);
            }
        }

    }
}
