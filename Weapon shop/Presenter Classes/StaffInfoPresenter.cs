using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Presenter_Classes
{
    public class StaffInfoPresenter
    {
        string name;
        string mail;
        string phone;
        string address;
        string nickname;
        string password;
        string confirmpassword;


        public StaffInfoPresenter(Staff staffInfoPage)
        {
            name = staffInfoPage.StaffName;
            mail = staffInfoPage.StaffMail;
            phone = staffInfoPage.StaffPhone;
            address = staffInfoPage.StaffAddress;
            nickname = staffInfoPage.StaffNickname;
            password = staffInfoPage.StaffPassword;
            confirmpassword = staffInfoPage.ConfirmPassword;
        }

        public void Add()
        {
            Weapon_shop.Data_Source.StaffDataSource sds = new Data_Source.StaffDataSource();
            sds.AddToList(new Utility_Classes.Staff(name, mail, phone, address, nickname, password));
        }

        public bool checkStaffDetails()
        {
            Data_Source.StaffDataSource sds = new Data_Source.StaffDataSource();
            Utility_Classes.Staff currentStaff = sds.ReturnAnItem(name);
            if (currentStaff == null) return false;
            else
            {
                mail = currentStaff.Mail;
                phone = currentStaff.Phone;
                address = currentStaff.Address;
                nickname = currentStaff.NickName;
                password = currentStaff.Password;
                return true;
            }
        }

        public void modifyStaffDetails()
        {
            Data_Source.StaffDataSource sds = new Data_Source.StaffDataSource();
            sds.ModifyList(new Utility_Classes.Staff(name, mail, phone, address, nickname, password));
        }

        public Utility_Classes.Staff checkStaffDetails(string name)
        {
            Data_Source.StaffDataSource sds = new Data_Source.StaffDataSource();
            return sds.ReturnAnItem(name);
            
        }

        public List<Utility_Classes.Staff> fetchStaffList()
        {
            List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>();
            Data_Source.StaffDataSource sds = new Data_Source.StaffDataSource();
            sds.returnEntireList(staffList);

            return staffList;
        }
    }
}
