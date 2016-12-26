using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataConnection;

namespace WCSA_Data_Source_Layer
{
    public abstract class GenericSourceClass<T>
    {
        protected static List<T> list = new List<T>();
        static GenericSourceClass<T> constructor;

        public GenericSourceClass()
        {
            if(constructor == null)
            {
                constructor = this;
                PopulateFromDatabase();
            }
            //Populating the list everytime ?? Really ???
           
        }

        public virtual void PopulateFromDatabase() { }


        public virtual void AddToList(T entity)
        {
            list.Add(entity);
            //new StaffDataAccess().Add()
        }

        public void returnEntireList(List<T> tempList)
        {
            foreach (T entity in list)
            {
                tempList.Add(entity);
            }
        }
        


        public void UpdateDatabase(T entity)
        {
            //Execute SQL query to reflect changes
        }

        public void UpdateDatabase(List<T> smallList, bool fullListUpdate)
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

    }
}
