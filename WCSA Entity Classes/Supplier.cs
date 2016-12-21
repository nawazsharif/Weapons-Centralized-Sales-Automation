using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class Supplier
    {
        string shopName;
        string mail;
        string address;
        string contact;
        string bankAccount;
        public string ShopName
        {
            set
            {
                //nickName = value;
            }
            get
            {
                return shopName;
            }
        }

        public string Mail
        {
            set { mail = value; }
            get
            {
                return mail;
            }
        }

        public string Address
        {
            set { address = value; }
            get
            {
                return address;
            }
        }

        public string Contact
        {
            set { contact = value; }
            get
            {
                return contact;
            }
        }

        public string BankAccount
        {
            set { bankAccount = value; }
            get
            {
                return bankAccount;
            }
        }

        public Supplier(string shopName, string mail, string address, string contact,
            string bankAccount)
        {
            this.shopName = shopName;
            this.mail = mail;
            this.address = address;
            this.contact = contact;
            this.bankAccount = bankAccount;
        }
        public Supplier()
        {
            this.shopName = null;
            this.mail = null;
            this.address = null;
            this.contact = null;
            this.bankAccount = null;
        }
    }
}
