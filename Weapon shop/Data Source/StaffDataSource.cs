using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Staff = Weapon_shop.Utility_Classes.Staff;

namespace Weapon_shop.Data_Source
{
    public class StaffDataSource
    {
        static List<Utility_Classes.Staff> staffList = new List<Utility_Classes.Staff>() {
            new Utility_Classes.Staff("Nawaz","kkk@kkk.ckk", "32452623", "NK-2", "Nawaz","123")};

        public StaffDataSource()
        {
            PopulateFromDatabase();
            //Weapon_shop.Delegates.Presenter_DataSource_Delegates.PDD += checkIfUserPassCombinationCorrect;
        }

        void PopulateFromDatabase()
        {
            //Execute query and fill up the list here
        }

        public void AddToList(Utility_Classes.Staff staff)
        {
            //int index = -1;
            //Utility_Classes.Staff requiredStaff = staffList.Find(staffList => staffList.Name.Equals(staff.Name));
            //index = staffList.IndexOf(requiredStaff);
            staffList.Add(staff);
        }


        public void DeleteFromList(string name)
        {
            staffList.RemoveAll(staffList => staffList.Name.Equals(name));
        }

        public void ModifyList(Utility_Classes.Staff staff)
        {

            Utility_Classes.Staff requiredStaff = staffList.Find(staffList => staffList.Name.Equals(staff.Name));
            int index = staffList.IndexOf(requiredStaff);
            staffList[index] = staff;

        }

        public Utility_Classes.Staff ReturnAnItem(string name)
        {
            return staffList.Find(staffList => staffList.Name.Equals(name));
        }

        void UpdateDatabase(Utility_Classes.Staff staff)
        {
            //Execute SQL query to reflect changes
        }

        public void UpdateDatabase(List<Utility_Classes.Staff> smallList, bool fullListUpdate)
        {
            if (fullListUpdate)
            {
                //Implement if necessary
                //Required once in a lifetime of the DB
            }
            else
            {
                //Implement if necessary
            }
        }

        public bool checkIfUserPassCombinationCorrect(string name, string pass)
        {
            Utility_Classes.Staff requiredStaff = staffList.Find(staffList => staffList.Name.Equals(name));
            if (requiredStaff == null) return false;
            else if (requiredStaff.Password.Equals(pass)) return true;
            else return false;


        }

        public void returnEntireList(List<Utility_Classes.Staff> newStaffList)
        {
            //StaffDataSource.staffList.CopyTo(staffList);

            foreach (Utility_Classes.Staff stf in staffList)
            {
                newStaffList.Add(stf);
            }
        }

        private static bool nameMatch(Utility_Classes.Staff staff, string name)
        {
            return staff.Name.ToString().Equals(name);
        }


    }
}
