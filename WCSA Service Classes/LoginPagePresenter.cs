using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCSA_Data_Source_Layer;

namespace WCSA_Service_Classes
{
    public class LoginPagePresenter
    {
        public LoginPagePresenter()
        {

        }

        public bool checkIfAuthorized(string username , string password)
        {
            StaffDataSource dataSource = new StaffDataSource();
            Console.WriteLine(username + "  " + password);
            return dataSource.checkIfUserPassCombinationCorrect(username, password);
        }
    }
}
