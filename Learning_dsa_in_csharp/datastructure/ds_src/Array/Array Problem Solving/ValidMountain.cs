using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class ValidMountain
    {
        public static bool Main(int[] array)
        {
            if (array.Length < 3) return false;

            int climb = 0;
            
            while(climb+1 < array.Length && array[climb] < array[climb+1]) 
            {
                climb++;
            }

            if(climb == 0 || climb == array.Length-1) return false;

            while(climb+1 < array.Length && array[climb] > array[climb + 1])
            {
                climb++;
            }

            return climb == array.Length-1;
        }
    }
}
