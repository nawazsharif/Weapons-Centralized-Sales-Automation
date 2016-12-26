using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataConnection
{
    public class CustomerDataAccess
    {
        public int Add(WCSA_Entity_Classes.Customer customer)
        {
            string query = string.Format("INSERT INTO CUSTOMER (Name, Mail,  Address,Phone, Nid, License) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", customer.Name, customer.Mail, customer.Address, customer.Phone, customer.NID, customer.License);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string nid)
        {
            string query = "DELETE FROM CUSTOMER WHERE Name=" + nid;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(WCSA_Entity_Classes.Customer customer)
        {
            string query = "UPDATE CUSTOMER SET Mail='" + customer.Mail + "', Address='" + customer.Address + "',Phone='" + customer.Phone + "', Name='" + customer.Name + "', License='" + customer.License + "' WHERE Nid='" + customer.NID + "'";
            return DataAccess.ExecuteQuery(query);
        }

        public List<WCSA_Entity_Classes.Customer> GetAll()
        {
            string query = "SELECT Name, Mail,  Address,Phone, Nid, License FROM CUSTOMER";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Customer customer = null;
            List<WCSA_Entity_Classes.Customer> customerList = new List<WCSA_Entity_Classes.Customer>();
            while (reader.Read())
            {
                customer = new WCSA_Entity_Classes.Customer();
                customer.Name = reader["Name"].ToString();
                customer.Mail = reader["Mail"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.NID = reader["Nid"].ToString();
                customer.License = reader["License"].ToString();

                customerList.Add(customer);
            }
            return customerList;
        }

        public WCSA_Entity_Classes.Customer GetByName(string name)
        {
            string query = "SELECT Name, Mail,  Address,Phone, Nid, License FROM CUSTOMER WHERE Name=" + name;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            WCSA_Entity_Classes.Customer customer = null;
            if (reader.HasRows)
            {
                customer = new WCSA_Entity_Classes.Customer();
                customer.Name = reader["Name"].ToString();
                customer.Mail = reader["Mail"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Address = reader["Address"].ToString();
                customer.NID = reader["Nid"].ToString();
                customer.License = reader["License"].ToString();
            }
            return customer;
        }
    }
}
