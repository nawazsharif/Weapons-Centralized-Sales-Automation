using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapon_shop.Data_Source
{
    interface ICommonFunctionalities
    {
        void PopulateFromDatabase();
        void AddToList();
        void DeleteFromList();
        void ModifyItem();
        Object ReturnAnItem(string id);
        void UpdateDatabase();
    }
}
