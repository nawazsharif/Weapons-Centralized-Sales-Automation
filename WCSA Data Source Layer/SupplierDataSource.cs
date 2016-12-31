using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using DataConnection;

namespace WCSA_Data_Source_Layer
{
    public class SupplierDatasource : GenericSourceClass<WCSA_Entity_Classes.Supplier>
    {
        // List update from database 
        public override void PopulateFromDatabase()
        {
            List<Supplier> supplierList = new SupplierDataAccess().GetAll();
            foreach (Supplier stf in supplierList)
            {
                list.Add(stf);
            }
        }


        // add mathood override from generic class 
        public override void AddToList(WCSA_Entity_Classes.Supplier entity)
        {
            list.Add(entity);
            //WCSA_Entity_Classes.Staff requiredStaff = new WCSA_Entity_Classes.Staff();
            //new StaffDataAccess().Add(requiredStaff);
            new SupplierDataAccess().Add(entity);
        }
        public void DeleteFromList(string sname)
        {
            list.RemoveAll(list => list.ShopName.Equals(sname));
            new SupplierDataAccess().Remove(sname);
        }

        //List modify from Database
        public void ModifyList(WCSA_Entity_Classes.Supplier supplier)
        {

            WCSA_Entity_Classes.Supplier requiredProduct = list.Find(list => list.ShopName.Equals(supplier.ShopName));
            int index = list.IndexOf(requiredProduct);
            list[index] = supplier;
            new SupplierDataAccess().Edit(supplier);
        }

        //search shop name from List 
         
        public WCSA_Entity_Classes.Supplier ReturnAnItem(string sname)
        {
            return list.Find(list => list.ShopName.Equals(sname));
        }
        public int returnMatching(string name)
        {
            WCSA_Entity_Classes.Supplier requiredSupplier= list.Find(SupplierList => SupplierList.ShopName.Equals(name));
            if (requiredSupplier != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
