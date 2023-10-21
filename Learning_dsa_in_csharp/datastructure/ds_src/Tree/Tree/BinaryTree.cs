using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BinaryTree
    {
        public Node Root;

        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(int data)
        {   
            Root = InsertRec(Root, data);
        }

        private Node InsertRec(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
                return root;
            }

            if( data < root.Data)
            {
                root.Left = InsertRec(root.Left, data);
            }
            else if(data > root.Data)
            {
                root.Right = InsertRec(root.Right, data);
            }

            return root;
        }
    }
}
