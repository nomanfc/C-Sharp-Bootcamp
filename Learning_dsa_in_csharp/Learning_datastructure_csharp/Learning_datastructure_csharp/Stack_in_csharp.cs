using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_datastructure_csharp
{
    internal class Stack_in_csharp
    {
        public static void MyCustomStack()
        {
            Stack myStack = new Stack();

            //push operation
            myStack.Push("Noman");
            myStack.Push("asif");
            myStack.Push("arshad");
            myStack.Push("Foysal");

            //count operation
            Console.WriteLine($"Stack Size : {myStack.Count}");

            //peek operatrion
            Console.WriteLine($"Top element : {myStack.Peek()}\n");

            //display stacks
            Console.WriteLine("Stack Elements are: ");
            foreach( var stack in myStack )
            {
                Console.WriteLine(stack);
            }

            //pop operation
            var poppedItem = myStack.Pop();
            Console.WriteLine($"\nPopped Element is: {poppedItem}\n");
            Console.WriteLine("Now Stack Elements are: ");
            foreach (var stack in myStack)
            {
                Console.WriteLine(stack);
            }

            //Search operation
            Console.WriteLine("\nEnter a element to search in stack: ");
            var inputSearchItem = Console.ReadLine();
            bool isSearchedItemInStack = myStack.Contains(inputSearchItem);
            if (isSearchedItemInStack)
            {
                Console.WriteLine($"{inputSearchItem} is found in the Stack");
            }
            else
            {
                Console.WriteLine($"{inputSearchItem} is not Found in the Stack");
            }


            //clear operation
            myStack.Clear();

            Console.WriteLine($"\nStack is empy now");
            Console.WriteLine($"Stack Size : {myStack.Count}");
        }
    }
}
