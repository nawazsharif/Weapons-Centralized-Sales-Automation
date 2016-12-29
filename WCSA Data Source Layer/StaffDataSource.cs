using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataConnection;
using WCSA_Entity_Classes;

namespace WCSA_Data_Source_Layer
{
    public class StaffDataSource : GenericSourceClass<WCSA_Entity_Classes.Staff>
    {

        public override void PopulateFromDatabase()
        {
            //WCSA_Entity_Classes.Staff requiredStaff = new WCSA_Entity_Classes.Staff();
            //new StaffDataAccess().Add(requiredStaff);
            //WCSA_Entity_Classes.Staff requiredStaff = list.Find(staffList => staffList.Name.Equals("Nawaz"));
            //if (requiredStaff == null)
            //{
            //    list.Add(new WCSA_Entity_Classes.Staff("Nawaz", "kkk@kkk.ckk", "32452623", "NK-2", "Nawaz", "123"));
            //    Console.WriteLine("Inserted into list \n");
            //}
            //Execute query and fill up the list here
            List<Staff> staffList = new StaffDataAccess().GetAll();
            foreach (Staff stf in staffList)
            {
                list.Add(stf);
            }
        }
        // add database 
        //add mathood override from generic 

        public override void AddToList(WCSA_Entity_Classes.Staff entity)
        {
            list.Add(entity);
            new StaffDataAccess().Add(entity);
        }

        public void DeleteFromList(string name)
        {
            list.RemoveAll(list => list.Name.Equals(name));
        }
        // Modifyy database 
        public void ModifyList(WCSA_Entity_Classes.Staff staff)
        {

            WCSA_Entity_Classes.Staff requiredStaff = list.Find(list => list.Name.Equals(staff.Name));
            int index = list.IndexOf(requiredStaff);
            list[index] = staff;
            //new StaffDataAccess().Edit(staff);

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

        public List<WCSA_Entity_Classes.Staff> returnMatchingStaffList(string nameSubstring)
        {
            List<Staff> tempList = new List<Staff>();
            foreach(Staff st in list)
            {
                if (st.Name.Contains(nameSubstring))
                {
                    tempList.Add(st);
                }
            }
            return tempList;
        }
    }
}
