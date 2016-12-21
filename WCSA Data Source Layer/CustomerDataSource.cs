using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Data_Source_Layer
{
    public class CustomerDataSource : GenericSourceClass<WCSA_Entity_Classes.Customer>
    {

        public void DeleteFromList(string nid)
        {
            list.RemoveAll(customerList => customerList.NID.Equals(nid));
        }

        public void ModifyList(WCSA_Entity_Classes.Customer customer)
        {

            WCSA_Entity_Classes.Customer requiredCustomer = list.Find(list => list.NID.Equals(customer.NID));
            int index = list.IndexOf(requiredCustomer);
            list[index] = customer;

        }

        WCSA_Entity_Classes.Customer ReturnAnItem(string nid)
        {
            return list.Find(list => list.NID.Equals(nid));
        }

    }
}
