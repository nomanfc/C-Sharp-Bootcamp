using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class InOrderTraversal
    {
        public static void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.Left);
                Console.Write(root.Data + " ");
                Inorder(root.Right);
            }
        }
    }
    
}
