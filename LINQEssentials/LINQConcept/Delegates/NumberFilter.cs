using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public  class NumberFilter
    {
       // public delegate bool Criteria(int value); 
       //.net 4.0'dan sonra hazır (built-in) generic delegeler yani diğer bir ifadeyle 'func' ve 'action' kavramları geldi.
        public  int[] Filter(int[] array, Func<int,bool> criteria)
        {
            List<int> filtered = new List<int>();
            foreach (var number in array)
            {
                if (criteria(number))
                {
                    filtered.Add(number);
                }

            }
            return filtered.ToArray();
        }
    }
}
