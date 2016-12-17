using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Data_Source
{
    public class SupplierDatasource
    {
        List<Weapon_shop.Utility_Classes.Supplier> supplierList;

        public SupplierDatasource()
        {
            supplierList = new List<Weapon_shop.Utility_Classes.Supplier>();
            PopulateFromDatabase();
        }

        void PopulateFromDatabase()
        {
            //Execute query and fill up the list here
        }

        void AddToList(Weapon_shop.Utility_Classes.Supplier supplier)
        {
            supplierList.Add(supplier);
        }

        void DeleteFromList(string sname)
        {
            supplierList.RemoveAll(supplierList => supplierList.ShopName.Equals(sname));
        }

        void ModifyList(Weapon_shop.Utility_Classes.Supplier supplier)
        {

            Weapon_shop.Utility_Classes.Supplier requiredProduct = supplierList.Find(supplierList => supplierList.ShopName.Equals(supplier.ShopName));
            int index = supplierList.IndexOf(requiredProduct);
            supplierList[index] = supplier;

        }

        Weapon_shop.Utility_Classes.Supplier ReturnAnItem(string sname)
        {
            return supplierList.Find(supplierList => supplierList.ShopName.Equals(sname));
        }

        void UpdateDatabase(Utility_Classes.Supplier supplier)
        {
            //Execute SQL query to reflect changes
        }

        void UpdateDatabase(List<Weapon_shop.Utility_Classes.Supplier> smallList, bool fullListUpdate)
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

        static bool nidMatch(Weapon_shop.Utility_Classes.Supplier supplier, string sname)
        {
            return supplier.ShopName.ToString().Equals(sname);
        }

    }
}
