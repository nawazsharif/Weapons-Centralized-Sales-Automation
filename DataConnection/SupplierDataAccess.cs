using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataConnection
{
    public class SupplierDataAccess
    {
        public int Add(WCSA_Entity_Classes.Supplier supplier)
        {
            string query = string.Format("INSERT INTO SUPPLIER (ShopName,mail,Address,Contact,BankAccount,AccountHolderName) VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", supplier.ShopName,supplier.Mail,supplier.Address,supplier.Contact,supplier.BankAccount,supplier.AccountHolderName);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string shopname)
        {
            string query = "DELETE FROM SUPPLIER WHERE Name=" + shopname;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(WCSA_Entity_Classes.Supplier supplier)
        {
            string query = "UPDATE SUPPLIER SET Mail='" + supplier.Mail + "', Address='" + supplier.Address + "',Contact='" + supplier.Contact + "', BankAccount='" + supplier.BankAccount + "', AccountHolderName='" + supplier.AccountHolderName + "' WHERE ShopName='" + supplier.ShopName + "'";
            return DataAccess.ExecuteQuery(query);
        }

        public List<WCSA_Entity_Classes.Supplier> GetAll()
        {
            string query = "SELECT ShopName,mail,Address,Contact,BankAccount,AccountHolderName FROM SUPPLIER";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Supplier supplier = null;
            List<WCSA_Entity_Classes.Supplier> supplierList = new List<WCSA_Entity_Classes.Supplier>();
            while (reader.Read())
            {
                supplier = new WCSA_Entity_Classes.Supplier();
                supplier.ShopName = reader["ShopName"].ToString();
                supplier.Mail = reader["Mail"].ToString();
                supplier.Contact = reader["Contact"].ToString();
                supplier.Address = reader["Address"].ToString();
                supplier.BankAccount = reader["BankAccount"].ToString();
                supplier.AccountHolderName = reader["AccountHolderName"].ToString();

                supplierList.Add(supplier);
            }
            return supplierList;
        }

        
    }
}
