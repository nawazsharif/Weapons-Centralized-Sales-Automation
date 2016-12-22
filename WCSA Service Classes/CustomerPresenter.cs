using System.Collections.Generic;
using WCSA_Data_Source_Layer;
using WCSA_Service_Classes;
using WCSA_Entity_Classes;

namespace WCSA_Service_Classes
{
    
    public class CustomerPresenter
    {
        public CustomerPresenter()
        {
        }

        public void Add(string name, string mail, string phone, string address, string nid, string licence)
        {
            CustomerDataSource sds = new CustomerDataSource();
            sds.AddToList(new WCSA_Entity_Classes.Customer(name, mail, phone, address, nid, licence));
        }

        public WCSA_Entity_Classes.Customer checkcustomerDetails(string nid)
        {
            CustomerDataSource sds = new CustomerDataSource();
            return sds.ReturnAnItem(nid);

        }

        public void modifyCustomerDetails(string name, string mail, string address, string phone, string nid, string licence)
        {
            CustomerDataSource sds = new CustomerDataSource();
            sds.ModifyList(new WCSA_Entity_Classes.Customer(name, mail, address, phone, nid, licence));
        }


        public List<WCSA_Entity_Classes.Customer> fetchCustomerList()
        {
            List<WCSA_Entity_Classes.Customer> customerList = new List<WCSA_Entity_Classes.Customer>();
            CustomerDataSource sds = new CustomerDataSource();
            sds.returnEntireList(customerList);
            return customerList;
        }
    }
}
