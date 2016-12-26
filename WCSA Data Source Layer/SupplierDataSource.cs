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
        public override void PopulateFromDatabase()
        {
            List<Supplier> supplierList = new SupplierDataAccess().GetAll();
            foreach (Supplier stf in supplierList)
            {
                list.Add(stf);
            }
        }

        public override void AddToList(WCSA_Entity_Classes.Supplier entity)
        {
            list.Add(entity);
            //WCSA_Entity_Classes.Staff requiredStaff = new WCSA_Entity_Classes.Staff();
            //new StaffDataAccess().Add(requiredStaff);
            new SupplierDataAccess().Add(entity);
        }
        void DeleteFromList(string sname)
        {
            list.RemoveAll(list => list.ShopName.Equals(sname));
        }

        public void ModifyList(WCSA_Entity_Classes.Supplier supplier)
        {

            WCSA_Entity_Classes.Supplier requiredProduct = list.Find(list => list.ShopName.Equals(supplier.ShopName));
            int index = list.IndexOf(requiredProduct);
            list[index] = supplier;
            new SupplierDataAccess().Edit(supplier);
        }

        public WCSA_Entity_Classes.Supplier ReturnAnItem(string sname)
        {
            return list.Find(list => list.ShopName.Equals(sname));
        }
    }
}
