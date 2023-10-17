using Array;
using Array_Operations;

Console.WriteLine("::::::::::::::::::::::- ARRAY -:::::::::::::::::::::::");

int length = 0;
int[] array = new int[10];

Console.WriteLine("\n01.Insert At End Of an Array: ");
length = InsertAtArrayEnd.Main(array, length, 100);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.WriteLine("\n02.Insert At Start Of an Array: ");
length = InsertAtArrayStart.Main(array, length, 120);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.WriteLine("\n03.Insert At Any Position Of an Array (3): ");
length = InsertAtGivenArrayPosition.Main(array, length, 3, 1200);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.WriteLine("\n04.Remove from End Of an Array: ");
length = RemoveLastArrayElement.Main(array, length);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.WriteLine("\n05.Remove from Start Of an Array: ");
length = RemoveFirstArrayElement.Main(array, length);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.WriteLine("\n06.Remove From Any Position Of an Array (3): ");
length = RemoveFromGivenArrayPosition.Main(array, length, 3);
Console.WriteLine("\n\nLength Now: " + length + "\n");

Console.ReadKey();