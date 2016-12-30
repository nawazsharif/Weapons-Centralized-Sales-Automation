using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;

namespace WCSA_Service_Classes
{
    public class SupplierInfoPresenter
    {
        public SupplierInfoPresenter()
        {
        }

        public void Add(string shopName, string mail, string address, string contact, string bankAccount, string accountHolderName)
        {
            SupplierDatasource sds = new SupplierDatasource();
            WCSA_Entity_Classes.Supplier sup = new WCSA_Entity_Classes.Supplier(shopName,mail,address,contact,bankAccount,accountHolderName);
            sds.AddToList(sup);
        }

        public WCSA_Entity_Classes.Supplier checkSupplierDetails(string sname)
        {
            SupplierDatasource sds = new SupplierDatasource();
            return sds.ReturnAnItem(sname);

        }

        public void modifySupplierDetails(string shopName, string mail, string address, string contact, string bankAccount, string accountHolderName)
        {
            SupplierDatasource sds = new SupplierDatasource();
            sds.ModifyList(new WCSA_Entity_Classes.Supplier(shopName, mail, address, contact, bankAccount,accountHolderName));
        }


        public List<WCSA_Entity_Classes.Supplier> fetchSupplierList()
        {
            List<WCSA_Entity_Classes.Supplier> supplierList = new List<WCSA_Entity_Classes.Supplier>();
            SupplierDatasource sds = new SupplierDatasource();
            sds.returnEntireList(supplierList);
            return supplierList;
        }
        public int returnMatching(string name)
        {
            return new SupplierDatasource().returnMatching(name);
        }
    }
}
