using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using DataConnection;
namespace WCSA_Data_Source_Layer
{
    public class ProductDataSource : GenericSourceClass<WCSA_Entity_Classes.Product>
    {

        public override void PopulateFromDatabase()
        {
            //WCSA_Entity_Classes.Product requiredStaff = list.Find(list => list.ProductCode.Equals("1"));
            //if (requiredStaff == null)
            //{
            //    list.Add(new WCSA_Entity_Classes.Product("1", "Glock 17", 5000, 10));
            //    Console.WriteLine("Inserted Glock 17 into product list \n");
            //}
            //requiredStaff = list.Find(list => list.ProductCode.Equals("2"));
            //if (requiredStaff == null)
            //{
            //    list.Add(new WCSA_Entity_Classes.Product("2", "ak_47", 10000, 10));
            //    Console.WriteLine("Inserted Ak 47 into product list \n");
            //}
            //requiredStaff = list.Find(list => list.ProductCode.Equals("3"));
            //if (requiredStaff == null)
            //{
            //    list.Add(new WCSA_Entity_Classes.Product("3", "Rifel", 100, 12));
            //    Console.WriteLine("Inserted Rifle into product list \n");
            //}
            //Execute query and fill up the list here
            List<Product> productList = new ProductDataAccess().GetAll();
            foreach (Product pds in productList)
            {
                list.Add(pds);
            }
        }
        public override void AddToList(WCSA_Entity_Classes.Product entity)
        {
            list.Add(entity);
            //WCSA_Entity_Classes.Staff requiredStaff = new WCSA_Entity_Classes.Staff();
            //new StaffDataAccess().Add(requiredStaff);
            new ProductDataAccess().Add(entity);
        }


        public void DeleteFromList(string code)
        {
            list.RemoveAll(list => list.ProductCode.Equals(code));
        }

        public void ModifyList(WCSA_Entity_Classes.Product product)
        {

            WCSA_Entity_Classes.Product requiredProduct = list.Find(list => list.ProductCode.Equals(product.ProductCode));
            int index = list.IndexOf(requiredProduct);
            list[index] = product;
            new ProductDataAccess().Edit(product);

        }

        public void ModifyItemInAccordanceWithInvoice(string productCode,uint quantity)
        {

            WCSA_Entity_Classes.Product requiredProduct = list.Find(list => list.ProductCode.Equals(productCode));
            int index = list.IndexOf(requiredProduct);

            Console.WriteLine("Product name : " + requiredProduct.ProductName);
            Console.WriteLine("Product Quantity : " + requiredProduct.Quantity);
            uint newQuantity = requiredProduct.Quantity - quantity;
            Console.WriteLine("new quantity on hand = " + newQuantity);
            requiredProduct.Quantity = newQuantity;
            Console.WriteLine("new product quantity = " + requiredProduct.Quantity);
            list[index] = requiredProduct;
            Console.WriteLine("Product quantity in list  = " + list[index].Quantity);

        }

        public WCSA_Entity_Classes.Product ReturnAnItem(string code)
        {
            return list.Find(list => list.ProductCode.Equals(code));
        }

        public WCSA_Entity_Classes.Product ReturnProductItem(string name)
        {
            return list.Find(list => list.ProductName.Equals(name));
        }
        public int returnMatching(string code)
        {
            WCSA_Entity_Classes.Product requiredProduct = list.Find(productList => productList.ProductCode.Equals(code));
            if (requiredProduct != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public List<Product> returnProductsWithMatchingName(string name)
        {
            List<Product> tempList = new List<Product>();
            string original = name;
            string upper = name.ToUpper();
            string lower = name.ToLower();

            foreach(Product p in list)
            {
                if (p.ProductName.Contains(original)  ||  p.ProductName.Contains(upper) || p.ProductName.Contains(lower)  ||
                    p.ProductName.Equals(name,StringComparison.OrdinalIgnoreCase))
                {
                    tempList.Add(p);
                }
            }

            return tempList;
        }
        public List<WCSA_Entity_Classes.Product> returnMatchingProductList(string nameSubstring)
        {
            List<Product> tempList = new List<Product>();
            foreach (Product st in list)
            {
                if (st.ProductName.Contains(nameSubstring))
                {
                    tempList.Add(st);
                }
            }
            return tempList;
        }

    }
}
