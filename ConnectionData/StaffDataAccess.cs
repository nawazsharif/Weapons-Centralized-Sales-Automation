using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConnectionData
{
    class StaffDataAccess
    {
        public int Add(WCSA_Entity_Classes.Staff staff)
        {
            string query = string.Format("INSERT INTO Person(Name, Mail Phone,Address,NickName,Password) VALUES({0}, '{1}', '{2}',{3}, '{3}','{4}')",staff.Name,staff.Mail,staff.Phone,staff.Address,staff.NickName,staff.Password);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string name)
        {
            string query = "DELETE FROM Person WHERE Name=" + name;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(WCSA_Entity_Classes.Staff staff)
        {
            string query = "UPDATE Person SET Name='" + staff.Name + "', Mail='" + staff.Mail + "' WHERE Phone='" + staff.Phone + "' WHERE Address='"+ staff.Address + "' WHERE NickName='" + staff.NickName+"'WHERE Password='"+staff.Password;
            return DataAccess.ExecuteQuery(query);
        }

        public List<WCSA_Entity_Classes.Staff> GetAll()
        {
            string query = "SELECT Id, Name, Phone FROM Person";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Staff staff = null;
            List<WCSA_Entity_Classes.Staff> personList = new List<WCSA_Entity_Classes.Staff>();
            while (reader.Read())
            {
                staff = new WCSA_Entity_Classes.Staff();
                staff.Name = reader["Name"].ToString();
                staff.Name = reader["Mail"].ToString();
                staff.Phone = reader["Phone"].ToString();
                staff.Address = reader["Address"].ToString();
                staff.NickName = reader["NickName"].ToString();
                staff.Password = reader["Password"].ToString();

                personList.Add(staff);
            }
            return personList;
        }

        public WCSA_Entity_Classes.Staff GetByName(string name)
        {
            string query = "SELECT Name, Mail Phone,Address,NickName,Password FROM STAFF WHERE Name=" + name;
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();

            WCSA_Entity_Classes.Staff staff = null;
            if (reader.HasRows)
            {
                staff = new WCSA_Entity_Classes.Staff();
                staff.Name = reader["Name"].ToString();
                staff.Name = reader["Mail"].ToString();
                staff.Phone = reader["Phone"].ToString();
                staff.Address = reader["Address"].ToString();
                staff.NickName = reader["NickName"].ToString();
                staff.Password= reader["Password"].ToString();

            }
            return staff;
        }

    }
}
