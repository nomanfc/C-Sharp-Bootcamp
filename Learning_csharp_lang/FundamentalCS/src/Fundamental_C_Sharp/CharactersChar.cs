using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamental_C_Sharp
{
    internal class CharactersChar
    {
        public static char SwitchCaseUsingChar(int points)
        {
            switch (points)
            {
                case 10:
                case 9:
                    return 'A';
                case 8:
                case 7:
                case 6:
                    return 'B';
                case 5:
                    return 'C';
                case 4:
                    return 'D';
                default:
                    return 'F';
            }
        }
    }
}
