using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DataConnection
{
    public class StaffDataAccess
    {
        public int Add(WCSA_Entity_Classes.Staff staff)
        {
            string query = string.Format("INSERT INTO STAFF (Name, Mail, Phone, Address, NickName, Password) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')",staff.Name,staff.Mail,staff.Phone,staff.Address,staff.NickName,staff.Password);
            return DataAccess.ExecuteQuery(query);
        }

        public int Remove(string name)
        {
            string query = "DELETE FROM STAFF WHERE Name=" + name;
            return DataAccess.ExecuteQuery(query);
        }

        public int Edit(WCSA_Entity_Classes.Staff staff)
        {
            string query = "UPDATE STAFF SET Mail='" + staff.Mail + "', Address='" + staff.Address + "',Phone='" + staff.Phone + "', NickName='" + staff.NickName + "', Password='" + staff.Password +"' WHERE Name='" + staff.Name +"'";
            return DataAccess.ExecuteQuery(query);
        }

        public List<WCSA_Entity_Classes.Staff> GetAll()
        {
            string query = "SELECT Name, Mail,Phone,Address,NickName,Password FROM STAFF";
            SqlDataReader reader = DataAccess.GetData(query);

            WCSA_Entity_Classes.Staff staff = null;
            List<WCSA_Entity_Classes.Staff> staffList = new List<WCSA_Entity_Classes.Staff>();
            while (reader.Read())
            {
                staff = new WCSA_Entity_Classes.Staff();
                staff.Name = reader["Name"].ToString();
                staff.Mail = reader["Mail"].ToString();
                staff.Phone = reader["Phone"].ToString();
                staff.Address = reader["Address"].ToString();
                staff.NickName = reader["NickName"].ToString();
                staff.Password = reader["Password"].ToString();

                staffList.Add(staff);
            }
            return staffList;
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
