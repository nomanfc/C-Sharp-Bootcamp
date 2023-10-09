using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_datastructure_csharp
{
    internal class Queue_in_csharp
    {
        public static void MyCustomQueue()
        {
            Queue myQueue = new();

            //Enqueue Operation
            myQueue.Enqueue("Noman");
            myQueue.Enqueue("Arshad");
            myQueue.Enqueue("Asif");
            myQueue.Enqueue("Foysal");

            //Count Items in Queue
            Console.WriteLine($"Total Items : {myQueue.Count}");

            //Display Queue Items
            Console.WriteLine("\nQueue Items are: ");
            foreach(var item in myQueue)
            {
                Console.WriteLine(item);
            }

            //Peek operation
            Console.WriteLine($"\nTop Item is : {myQueue.Peek()}");

            //Dequeue operation
            var removedItem  = myQueue.Dequeue();
            Console.WriteLine($"\nItem Removed : {removedItem}");

            //Peek operation
            Console.WriteLine($"\nNow Top Item is : {myQueue.Peek()}");

            //Display Queue Items
            Console.WriteLine("\nRemaining Queue Items are: ");
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }

            //Searching items in Queue
            Console.WriteLine("\nEnter search item: ");
            var searchIeam = Console.ReadLine();
            bool isSearchItemFound = myQueue.Contains(searchIeam);
            if (isSearchItemFound)
            {
                Console.WriteLine($"{searchIeam} is found in Queue.")
            }
            else
            {
                Console.WriteLine($"{searchIeam} is not found in Queue.")
            }


        }
    }
}
