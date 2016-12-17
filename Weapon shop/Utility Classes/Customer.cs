﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Utility_Classes
{
    public class Customer : Person
    {
        string nid;
        string license;
        public string NID
        {
            set
            {
                //nickName = value;
            }
            get
            {
                return nid;
            }
        }

        public string License
        {
            set { }
            get
            {
                return license;
            }
        }

        public Customer(string name, string mail, string phone, string address,
            string nid, string license)
        {
            this.name = name;
            this.mail = mail;
            this.phone = phone;
            this.address = address;
            this.nid = nid;
            this.license = license;
        }
        public Customer()
        {
            this.name = null;
            this.mail = null;
            this.phone = null;
            this.address = null;
            this.nid = null;
            this.license = null;
        }
    }
}
