using System;
using System.Collections;

namespace LearningC_
{
    internal class MyCustomStack
    {
        public static void MyStack()
        {
            Stack myStack = new Stack();

            myStack.Push("Hello 1");
            myStack.Push("Hello 2");
            myStack.Push("Hello 3");
            myStack.Push("Hello 4");

            var poppedValue = myStack.Pop();
            Console.WriteLine($"Popped Element ==> {poppedValue}");

            var value = myStack.Peek();
            Console.WriteLine($"Now Top Element is ==> {value}");

            Console.WriteLine($"\nRemaining Elements in the Stack: ");
            foreach (var i in myStack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
