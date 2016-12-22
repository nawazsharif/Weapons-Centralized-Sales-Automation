using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Data_Source_Layer
{
    public class StaffDataSource : GenericSourceClass<WCSA_Entity_Classes.Staff>
    {

        public override void PopulateFromDatabase()
        {
            WCSA_Entity_Classes.Staff requiredStaff = list.Find(staffList => staffList.Name.Equals("Nawaz"));
            if (requiredStaff == null)
            {
                list.Add(new WCSA_Entity_Classes.Staff("Nawaz", "kkk@kkk.ckk", "32452623", "NK-2", "Nawaz", "123"));
                Console.WriteLine("Inserted into list \n");
            }
            //Execute query and fill up the list here
        }

        public void DeleteFromList(string name)
        {
            list.RemoveAll(list => list.Name.Equals(name));
        }

        public void ModifyList(WCSA_Entity_Classes.Staff staff)
        {

            WCSA_Entity_Classes.Staff requiredStaff = list.Find(list => list.Name.Equals(staff.Name));
            int index = list.IndexOf(requiredStaff);
            list[index] = staff;

        }

        public WCSA_Entity_Classes.Staff ReturnAnItem(string name)
        {
            return list.Find(list => list.Name.Equals(name));
        }


        public bool checkIfUserPassCombinationCorrect(string name, string pass)
        {
            WCSA_Entity_Classes.Staff requiredStaff = list.Find(staffList => staffList.Name.Equals(name));
            if (requiredStaff == null) return false;
            else if (requiredStaff.Password.Equals(pass)) return true;
            else return false;
        }
    }
}
