using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class MultiDimentionalArray
    {
        public static void TwoDArray()
        {
            char[,] letters = new char[3,3];

            letters[0, 0] = 'A';
            letters[0, 1] = 'B';
            letters[0, 2] = 'C';
            letters[1, 0] = 'D';
            letters[1, 1] = 'E';
            letters[1, 2] = 'F';
            letters[2, 0] = 'G';
            letters[2, 1] = 'H';
            letters[2, 2] = 'I';

            Console.Write($"\nColumn: 0  1  2\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"\nRow {i} :");
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($" {letters[i,j]} ");
                }
                Console.WriteLine();
            }
        } 
    }
}
