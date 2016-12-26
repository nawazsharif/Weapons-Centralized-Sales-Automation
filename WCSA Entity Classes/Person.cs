using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public abstract class Person
    {
        protected string name;
        protected string mail;
        protected string phone;
        protected string address;

        public string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }
        public string Mail
        {
            set
            {
                mail = value;
            }
            get { return mail; }
        }
        public string Phone
        {
            set
            {
                phone = value;
            }
            get { return phone; }
        }
        public string Address
        {
            set
            {
                address = value;
            }
            get { return address; }
        }
    }
}
