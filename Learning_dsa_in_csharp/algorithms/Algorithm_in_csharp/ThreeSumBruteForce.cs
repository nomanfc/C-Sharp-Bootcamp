﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_csharp
{
    internal class ThreeSumBruteForce
    {
        public static int ThreeSumBF(int[] a)
        {
            int count = 0;
            int N = a.Length;

            for(int i = 0; i<N; i++)
            {
                for(int j = i+1; j<N; j++)
                {
                    for(int k = j+1; k<N; k++)
                    {
                        if (a[i] + a[j] + a[k] == 0)
                        {
                                count++;
                            
                        }
                    }
                }
            }

            return count;
        }
    }
}
