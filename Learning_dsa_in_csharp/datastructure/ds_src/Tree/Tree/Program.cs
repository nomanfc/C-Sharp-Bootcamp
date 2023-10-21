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

Console.ReadKey();