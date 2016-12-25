using System.Collections.Generic;
using WCSA_Data_Source_Layer;


namespace WCSA_Service_Classes
{
    public class StaffInfoPresenter
    {
        public StaffInfoPresenter()
        {
        }

        public void Add(string name, string mail, string phone, string address, string nickname, string password)
        {
            StaffDataSource sds = new StaffDataSource();
            WCSA_Entity_Classes.Staff stf = new WCSA_Entity_Classes.Staff(name, mail, phone, address, nickname, password);
            sds.AddToList(stf);
        }

        public WCSA_Entity_Classes.Staff checkStaffDetails(string name)
        {
            StaffDataSource sds = new StaffDataSource();
            return sds.ReturnAnItem(name);

        }

        public void modifyStaffDetails(string name, string mail, string phone, string address, string nickname, string password)
        {
            StaffDataSource sds = new StaffDataSource();
            sds.ModifyList(new WCSA_Entity_Classes.Staff(name, mail, phone, address, nickname, password));
        }


        public List<WCSA_Entity_Classes.Staff> fetchStaffList()
        {
            List<WCSA_Entity_Classes.Staff> staffList = new List<WCSA_Entity_Classes.Staff>();
            StaffDataSource sds = new StaffDataSource();
            sds.returnEntireList(staffList);
            return staffList;
        }
    }
}