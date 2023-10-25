using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BasicBinaryTreeNode
    {
        public char Value;
        public BasicBinaryTreeNode Left;
        public BasicBinaryTreeNode Right;

        public BasicBinaryTreeNode(char val)
        {
            Value = val;
            Left = null;
            Right = null;
        }

    }
}
