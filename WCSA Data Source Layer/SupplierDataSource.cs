using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Data_Source_Layer
{
    public class SupplierDatasource : GenericSourceClass<WCSA_Entity_Classes.Supplier>
    {

        void DeleteFromList(string sname)
        {
            list.RemoveAll(list => list.ShopName.Equals(sname));
        }

        public void ModifyList(WCSA_Entity_Classes.Supplier supplier)
        {

            WCSA_Entity_Classes.Supplier requiredProduct = list.Find(list => list.ShopName.Equals(supplier.ShopName));
            int index = list.IndexOf(requiredProduct);
            list[index] = supplier;

        }

        public WCSA_Entity_Classes.Supplier ReturnAnItem(string sname)
        {
            return list.Find(list => list.ShopName.Equals(sname));
        }
    }
}
