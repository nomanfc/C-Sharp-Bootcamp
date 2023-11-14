using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace DynammicProblemSolutions
{
    internal class LCS
    {
        // Function to find the Longest Common Subsequence (LCS) of two strings
        public static int Main(string strOne, string strTwo)
        {
            // Get the lengths of the input strings
            int m = strOne.Length;
            int n = strTwo.Length;

            // Create a 2D array to store the length of LCS for substrings
            int[,] lcs = new int[m + 1, n + 1];

            // Build the LCS matrix using dynamic programming
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (strOne[i - 1] == strTwo[j - 1])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }

            // Retrieve the LCS and its length
            int index = lcs[m, n];
            char[] lcs_letters = new char[index + 1];
            int k = m, l = n;

            while (k > 0 && l > 0)
            {
                if (strOne[k - 1] == strTwo[l - 1])
                {
                    lcs_letters[index - 1] = strOne[k - 1];
                    k--;
                    l--;
                    index--;
                }
                else if (lcs[k - 1, l] > lcs[k, l - 1])
                {
                    k--;
                }
                else
                {
                    l--;
                }
            }

            // Display the common subsequence and its length
            Console.Write("Common Subsequence: ");
            foreach (char c in lcs_letters)
            {
                Console.Write(c + " ");
            }

            Console.Write("\nLength: ");
            return lcs[m, n];
        }
    }
}
