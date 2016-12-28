using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataConnection
{
    public class ProductDataAccess
    {
        public int Add(WCSA_Entity_Classes.Product product)
        {
            string query = string.Format("INSERT INTO PRODUCT (ProductCode, ProductName, Price, Quantity) VALUES('{0}', '{1}', '{2}', '{3}')", product.ProductCode, product.ProductName, product.Price, product.Quantity);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string code)
        {
            string query = "DELETE FROM PRODUCT WHERE Name=" + code;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(WCSA_Entity_Classes.Product product)
        {
            string query = "UPDATE PRODUCT SET ProductName='" + product.ProductName+ "',Quantity='" + product.Quantity + "', Price='" + product.Price + "' WHERE ProductCode='" + product.ProductCode + "'";
            return DataAccess.ExecuteQuery(query);
        }

        public List<WCSA_Entity_Classes.Product> GetAll()
        {
            string query = "SELECT ProductCode, ProductName, Price, Quantity FROM PRODUCT";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Product product = null;
            List<WCSA_Entity_Classes.Product> productList = new List<WCSA_Entity_Classes.Product>();
            while (reader.Read())
            {
                product = new WCSA_Entity_Classes.Product();
                product.ProductName = reader["ProductName"].ToString();
                product.ProductCode = reader["ProductCode"].ToString();
                product.Price =Convert.ToDouble(reader["Price"].ToString());
                product.Quantity = Convert.ToUInt32(reader["Quantity"].ToString());
                productList.Add(product);
            }
            return productList;
        }
    }
}
