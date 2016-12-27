using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Entity_Classes;
using DataConnection;

namespace WCSA_Data_Source_Layer
{
    public class BankAccountDatasource : GenericSourceClass<WCSA_Entity_Classes.BankAccount>
    {
        public override void PopulateFromDatabase()
        {
           
            List<BankAccount> bankaccountList = new BankAccountDataAccess().GetAll();
            foreach (BankAccount stf in bankaccountList)
            {
                list.Add(stf);
            }
        }
        public override void AddToList(WCSA_Entity_Classes.BankAccount entity)
        {
            list.Add(entity);
            new BankAccountDataAccess().Add(entity);
        }
    }
}
