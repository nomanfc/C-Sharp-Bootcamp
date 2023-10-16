using Array;

Console.WriteLine("::::::::::::::::::::::- ARRAY -:::::::::::::::::::::::");

int length = 0;
int[] array = new int[10];



Console.WriteLine("\n01.Insert At End Of an Array: ");
length = InsertAtArrayEnd.Main(array, length, 100);

Console.WriteLine("\n02.Insert At Start Of an Array: ");
length = InsertAtArrayStart.Main(array, length, 120);

Console.WriteLine("\n03.Insert At Any Position Of an Array: ");
length = InsertAtGivenArrayPosition.Main(array, length, 10, 120);
if(length == 404) { Console.WriteLine("Length out of bound"); }

Console.WriteLine("Length: " + length);
Console.ReadKey();