using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Data_Source_Layer
{
    public class ProductDataSource : GenericSourceClass<WCSA_Entity_Classes.Product>
    {

        public override void PopulateFromDatabase()
        {
            list.Add(new WCSA_Entity_Classes.Product("1", "Glock 17", 5000, 10));
            list.Add(new WCSA_Entity_Classes.Product("2", "ak_47", 10000, 10));
            list.Add(new WCSA_Entity_Classes.Product("3", "Rifel", 100, 12));
            //Execute query and fill up the list here
        }


        public void DeleteFromList(string code)
        {
            list.RemoveAll(list => list.ProductCode.Equals(code));
        }

        public void ModifyList(WCSA_Entity_Classes.Product product)
        {

            WCSA_Entity_Classes.Product requiredProduct = list.Find(list => list.ProductCode.Equals(product.ProductCode));
            int index = list.IndexOf(requiredProduct);
            list[index] = product;

        }

        public WCSA_Entity_Classes.Product ReturnAnItem(string code)
        {
            return list.Find(list => list.ProductCode.Equals(code));
        }

    }
}
