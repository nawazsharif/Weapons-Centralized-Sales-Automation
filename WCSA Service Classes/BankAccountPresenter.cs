using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;
using WCSA_Entity_Classes;
namespace WCSA_Service_Classes
{
    public class BankAccountPresenter
    {

        public BankAccountPresenter()
        {
        }

        public void Add(string bankName, string bankAccountNo, string accountHolderName)
        {
            BankAccountDatasource sds = new BankAccountDatasource();
            WCSA_Entity_Classes.BankAccount ba = new WCSA_Entity_Classes.BankAccount(bankName,bankAccountNo,accountHolderName);
            sds.AddToList(ba);
        }
        public List<WCSA_Entity_Classes.BankAccount> fetchBankList()
        {
            List<WCSA_Entity_Classes.BankAccount> AccountList = new List<WCSA_Entity_Classes.BankAccount>();
            BankAccountDatasource sds = new BankAccountDatasource();
            sds.returnEntireList(AccountList);

            return AccountList;
        }
    }
}
