using Tree;

Console.WriteLine("::::::::::::::::::::- Tree Data Structure -::::::::::::::::::::");

BinaryTree tree = new BinaryTree();

// Insert data into the binary tree
tree.Insert(50);
tree.Insert(30);
tree.Insert(20);
tree.Insert(40);
tree.Insert(70);
tree.Insert(60);
tree.Insert(80);

Console.WriteLine("Binary Tree Inorder Traversal:");
InOrderTraversal.Inorder(tree.Root);

Console.WriteLine("\n\n::::::::::::::::::::- Basic Binary Tree -::::::::::::::::::::");

BasicBinaryTreeNode a = new BasicBinaryTreeNode('A');
BasicBinaryTreeNode b = new BasicBinaryTreeNode('B');
BasicBinaryTreeNode c = new BasicBinaryTreeNode('C');
BasicBinaryTreeNode d = new BasicBinaryTreeNode('D');
BasicBinaryTreeNode e = new BasicBinaryTreeNode('E');
BasicBinaryTreeNode f = new BasicBinaryTreeNode('F');

a.Left = b;
a.Right = c;
b.Left = d;
b.Right = e;
c.Right = f;

//Visual Representation
//
//         A
//       /   \
//      B      C
//    /   \      \
//  D       E      F


Console.ReadKey();