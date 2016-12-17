using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staff = Weapon_shop.Utility_Classes.Staff;

namespace Weapon_shop.Presenter_Classes
{
    public class LoginPagePresenter
    {
        string username, password;
        public LoginPagePresenter(Form_Login LoginPage)
        {

            username = LoginPage.UserName.ToString();
            password = LoginPage.Password.ToString();

        }

        public bool checkIfAuthorized()
        {
            Weapon_shop.Data_Source.StaffDataSource dataSource = new Weapon_shop.Data_Source.StaffDataSource();
            return dataSource.checkIfUserPassCombinationCorrect(username, password);
        }
    }
}
