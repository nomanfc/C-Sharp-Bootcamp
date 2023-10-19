using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problem_Solving
{
    internal class EvenSquaredArray
    {
        public static void Main(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(i%2 == 0)
                {
                    array[i] = array[i] * array[i];
                }
            }

            Utility.Display(array);
        }
    }
}
