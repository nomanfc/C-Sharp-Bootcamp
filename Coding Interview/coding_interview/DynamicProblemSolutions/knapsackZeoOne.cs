using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProblemSolutions
{
    internal class knapsackZeoOne
    {
        public static int Main(int[] values, int[] weights, int capacity, int n)
        {
            // Create a 2D array to store intermediate results
            int[,] dp = new int[n + 1, capacity + 1];

            // Populate the array using bottom-up dynamic programming
            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    // Base case: If there are no items or the knapsack has no capacity, the value is 0
                    if (i == 0 || w == 0)
                    {
                        dp[i, w] = 0;
                    }


                    // If the current item's weight is less than or equal to the remaining capacity,
                    // choose the maximum value between including and excluding the item
                    else if (weights[i - 1] <= w)
                    {
                        dp[i, w] = Math.Max(values[i - 1] + dp[i - 1, w - weights[i - 1]], dp[i - 1, w]);
                    }


                    // If the current item cannot fit into the knapsack, use the value from the previous row
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            // Backtrack to find the selected items
            var selectedItems = new List<int>();
            int k = n, l = capacity;

            while (k > 0 && l > 0)
            {
                if (dp[k, l] != dp[k - 1, l])
                {
                    selectedItems.Add(k - 1);
                    l -= weights[k - 1];
                }
                k--;
            }

            // Reverse the list to get the correct order
            selectedItems.Reverse();



            // The final result is stored in the bottom-right cell of the array
            return dp[n, capacity];
        }
    }
}
