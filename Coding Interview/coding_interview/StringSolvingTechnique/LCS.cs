using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace StringSolvingTechnique
{
    internal class LCS
    {
        public static int Main(string strOne, string strTwo)
        {
            int m = strOne.Length;
            int n = strTwo.Length;

            int[,] lcs = new int[m+1, n+1];
                
            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if (strOne[i-1] == strTwo[j - 1])
                    {
                        lcs[i, j] = lcs[i-1, j-1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i-1, j], lcs[i, j-1]);
                    }
                }
            }

            return lcs[m,n];
        }
    }
}
