using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Data_Source
{
    public class CustomerDataSource
    {
        List<Weapon_shop.Utility_Classes.Customer> customerList;

        public CustomerDataSource()
        {
            customerList = new List<Weapon_shop.Utility_Classes.Customer>();
            PopulateFromDatabase();
        }

        void PopulateFromDatabase()
        {
            //Execute query and fill up the list here
        }

        void AddToList(Weapon_shop.Utility_Classes.Customer customer)
        {
            customerList.Add(customer);
        }

        void DeleteFromList(string nid)
        {
            customerList.RemoveAll(customerList => customerList.NID.Equals(nid));
        }

        void ModifyList(Weapon_shop.Utility_Classes.Customer customer)
        {

            Weapon_shop.Utility_Classes.Customer requiredCustomer = customerList.Find(customerList => customerList.NID.Equals(customer.NID));
            int index = customerList.IndexOf(requiredCustomer);
            customerList[index] = customer;

        }

        Weapon_shop.Utility_Classes.Customer ReturnAnItem(string nid)
        {
            return customerList.Find(customerList => customerList.NID.Equals(nid));
        }

        void UpdateDatabase(Customer customer)
        {
            //Execute SQL query to reflect changes
        }

        void UpdateDatabase(List<Weapon_shop.Utility_Classes.Customer> smallList, bool fullListUpdate)
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

        static bool nidMatch(Weapon_shop.Utility_Classes.Customer customer, string nid)
        {
            return customer.NID.ToString().Equals(nid);
        }

    }
}
