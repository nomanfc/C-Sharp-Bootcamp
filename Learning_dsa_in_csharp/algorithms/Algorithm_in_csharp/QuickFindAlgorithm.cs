using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_csharp
{
    public class QuickFindAlgorithm
    {
        int[] id;

        //this constructor sets objects to ifself O(N)
        public QuickFindAlgorithm(int N)
        {
            id = new int[N];

            for(int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        //checks if p and q are connected components O(1)
        public bool Connected (int p, int q)
        {
            if (id[p] == id[q])
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        //change all entries with id[p] to id[q] O(2N + 2) or O(N)
        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            for(int i = 0; i< id.Length; i++)
            {
                if (id[i] == pid)
                {
                    id[i] = qid;
                }
            }

        }


        public void PrintValue()
        {
            Console.Write("\nConnection Status: ");
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write(id[i] + " ");
            }
            Console.Write("\n\n");
        }

    }
}
