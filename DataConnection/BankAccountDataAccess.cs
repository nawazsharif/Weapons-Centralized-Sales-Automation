using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using System.Data.SqlClient;

namespace DataConnection
{
    public class BankAccountDataAccess
    {
        public int Add(WCSA_Entity_Classes.BankAccount ba)
        {
            string query = string.Format("INSERT INTO BANKACCOUNT (BankName,AccountNo,AccountHolderName) VALUES('{0}', '{1}', '{2}')",ba.BankName,ba.BankAccountNo,ba.BankAccountName );
            return DataAccess.ExecuteQuery(query);
        }
        public List<WCSA_Entity_Classes.BankAccount> GetAll()
        {
            string query = "SELECT BankName,AccountNo,AccountHolderName FROM BANKACCOUNT";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.BankAccount ba = null;
            List<WCSA_Entity_Classes.BankAccount> bankAccoountList = new List<WCSA_Entity_Classes.BankAccount>();
            while (reader.Read())
            {
                ba = new WCSA_Entity_Classes.BankAccount();
                ba.BankName = reader["BankName"].ToString();
                ba.BankAccountNo = reader["AccountNo"].ToString();
                ba.BankAccountName = reader["AccountHolderName"].ToString();
                bankAccoountList.Add(ba);
            }
            return bankAccoountList;
        }
    }
}
