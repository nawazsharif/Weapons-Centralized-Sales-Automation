using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class BankAccount
    {
        string bankName;
        string bankAccountNo;
        string accountHolderName;

        public string BankName
        {
            set
            {
                this.bankName = value;
            }
            get
            {
                return bankName;
            }
        }

        public string BankAccountNo
        {
            set
            {
                this.bankAccountNo = value;
            }
            get
            {
                return bankAccountNo;
            }
        }
        public string BankAccountName
        {
            set
            {
                this.accountHolderName = value;
            }
            get
            {
                return accountHolderName;
            }
        }
        public BankAccount(string bankName,string bankAccountNo, string accountHolderName)
        {
            this.bankAccountNo = bankAccountNo;
            this.bankName = bankName;
            this.BankAccountName = accountHolderName;
        }

        public BankAccount()
        {
            this.bankAccountNo = null;
            this.bankName = null;
            this.BankAccountName = null;
        }
    }
}
