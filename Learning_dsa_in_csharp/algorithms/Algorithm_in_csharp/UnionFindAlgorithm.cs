using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_in_csharp
{
    internal class UnionFindAlgorithm
    {
        int[] id;
        int[] sz;

        //Constructor will assign objects to itself. O(N)
        public UnionFindAlgorithm (int N)
        {
            id = new int[N];
            sz = new int[N];

            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        //Root method will chase the parent pointer until it reach root  O(N)
        private int Root (int root)
        {
            while (id[root] != root)
            {
                //path compression improvement 2
                id[root] = id[id[root]];

                root = id[root];
            }

            return root;
        }

        //Connected method will check if p and q are connected, if p and q have same root they are connected  O(N)
        public bool Connected (int p, int q)
        {
            return Root(p) == Root(q);
        }

        //Union method will connect the Root of p to Root of q  O(N)`
        public void Union(int p , int q)
        {
            int i = Root(p);
            int j = Root(q);

            //check size of conneted components and add new component according to it to keep the balance.
            if (sz[i] < sz[j])
            {
                id[i] = j;
                sz[j] += sz[i];
            }
            else
            {
                id[j] = i;
                sz[i] += sz[j];
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
