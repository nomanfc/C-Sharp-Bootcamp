using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class SearchingDoubleNumber
    {
        public static bool Main(int[] array)
        {
            HashSet<int> set = new HashSet<int>();

            for(int i=0; i<array.Length; i++)
            {
                int current = array[i];

                if (set.Contains(current*2) || (current%2 == 0 && set.Contains(current / 2)))
                {
                    return true;
                }

                set.Add(current);
            }

            return false;
        }
    }
}
