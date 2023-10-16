using Array;

Console.WriteLine("::::::::::::::::::::::- ARRAY -:::::::::::::::::::::::");

int length = 0;
int[] array = new int[10];



Console.WriteLine("\n01.Insert At End Of an Array: ");
length = InsertAtArrayEnd.Main(array, length, 100);

Console.WriteLine("\n02.Insert At Start Of an Array: ");
length = InsertAtArrayStart.Main(array, length, 120);




Console.WriteLine("Length: " + length);
Console.ReadKey();