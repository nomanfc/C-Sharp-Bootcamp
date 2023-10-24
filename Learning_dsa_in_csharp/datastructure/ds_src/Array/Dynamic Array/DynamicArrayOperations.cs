using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Array
{
    internal class DynamicArrayOperations
    {
        public static void Main()
        {
            // 1. initialize
            List<int> v0 = new List<int>();
            List<int> v1 = null; // v1 == null

            // 2. cast an array to a list
            int[] a = { 0, 1, 2, 3, 4 };
            v1 = new List<int>(a);

            // 3. make a copy
            List<int> v2 = v1; // another reference to v1
            List<int> v3 = new List<int>(v1); // make an actual copy of v1

            // 4. get length
            Console.WriteLine("The size of v1 is: " + v1.Count);

            // 5. access element
            Console.WriteLine("The first element in v1 is: " + v1[0]);

            // 6. iterate the list
            Console.Write("[Version 1] The contents of v1 are:");
            for (int i = 0; i < v1.Count; ++i)
            {
                Console.Write(" " + v1[i]);
            }
            Console.WriteLine();

            Console.Write("[Version 2] The contents of v1 are:");
            foreach (int item in v1)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // 7. modify element
            v2[0] = 5; // modify v2 will actually modify v1
            Console.WriteLine("The first element in v1 is: " + v1[0]);
            v3[0] = -1;
            Console.WriteLine("The first element in v1 is: " + v1[0]);

            // 8. sort
            v1.Sort();

            // 9. add new element at the end of the list
            v1.Add(-1);
            v1.Insert(1, 6);

            // 10. delete the last element
            v1.RemoveAt(v1.Count - 1);
        }
    }
}
