using Array_Problem_Solving;

Console.WriteLine("::::::::::::::::::::- Problem Solving With Array -:::::::::::::::::::::");

Console.WriteLine("\n01. Add Duplicate Zero");
int[] array = new int[8] {0,1,5,3,0,1,4,0};
Console.WriteLine($"Given Array: [0,1,5,3,0,1,4,0].\nExpected Output: [0,0,1,5,3,0,0,1]");
Console.Write("Output: ");
DuplicateZeros.DuplicateZero(array);

Console.ReadKey();