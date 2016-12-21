using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class Staff : Person
    {
        string nickName;
        string password;
        public string NickName
        {
            set
            {
                //nickName = value;
            }
            get
            {
                return nickName;
            }
        }
        public string Password
        {
            set
            {
                //nickName = value;
            }
            get
            {
                return password;
            }
        }

        public Staff(string name, string mail, string phone, string address, string nickName, string password)
        {
            this.name = name;
            this.mail = mail;
            this.phone = phone;
            this.address = address;
            this.nickName = name;
            this.password = password;

        }
        public Staff()
        {
            this.name = null;
            this.mail = null;
            this.phone = null;
            this.address = null;
            this.nickName = null;
            this.password = null;
        }
    }
}
