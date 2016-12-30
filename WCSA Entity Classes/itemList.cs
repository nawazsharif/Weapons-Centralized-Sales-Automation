using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCSA_Entity_Classes
{
    public class itemListTuple<T1, T2>
    {
        List<Tuple<T1,T2>> list;
        int index;

        public itemListTuple()
        {
            list = new List<Tuple<T1, T2>>();
            index = 0;
        }

        public bool Add(T1 a, T2 b)
        {
            Tuple<T1, T2> x = new Tuple<T1, T2>(a, b);
            list.Add(x);
            return true;
        }

        public List<Tuple<T1, T2>> getEntireList()
        {
            return new List<Tuple<T1, T2>>(list);
        }

        public Tuple<T1,T2> getNextItem()
        {
            if (index < list.Count)
            {
                Tuple<T1, T2> x = list[index];
                index++;
                return x;
            }
            return null;
        }
    }
}
