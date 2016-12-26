using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using DataConnection;

namespace WCSA_Data_Source_Layer
{
    public class CustomerDataSource : GenericSourceClass<WCSA_Entity_Classes.Customer>
    {

        public override void PopulateFromDatabase()
        {
            //Customer cst = list.Find(list => list.NID.Equals("1"));
            //if(cst == null)
            //list.Add(new WCSA_Entity_Classes.Customer("nahid", "fgh@fdkvb", "017","djfhjkh","1", "10"));
            //cst = list.Find(list => list.NID.Equals("2"));
            //if(cst== null)
            //list.Add(new WCSA_Entity_Classes.Customer("sawon", "fgh@fdkvb", "017", "djfhjkh", "2", "10"));

            //Execute query and fill up the list here
            List<Customer> customerList = new CustomerDataAccess().GetAll();
            foreach (Customer stf in customerList)
            {
                list.Add(stf);
            }
        }

        public void DeleteFromList(string nid)
        {
            list.RemoveAll(customerList => customerList.NID.Equals(nid));
        }

        public void ModifyList(WCSA_Entity_Classes.Customer customer)
        {

            WCSA_Entity_Classes.Customer requiredCustomer = list.Find(list => list.NID.Equals(customer.NID));
            int index = list.IndexOf(requiredCustomer);
            list[index] = customer;
            new CustomerDataAccess().Edit(customer);

        }

        public WCSA_Entity_Classes.Customer ReturnAnItem(string nid)
        {
            return list.Find(list => list.NID.Equals(nid));
        }

    }
}
