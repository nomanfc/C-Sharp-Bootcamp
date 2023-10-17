using Array_Problem_Solving;

Console.WriteLine("::::::::::::::::::::- Problem Solving With Array -:::::::::::::::::::::");

Console.WriteLine("\n01. Add Duplicate Zero");
int[] array = new int[8] {0,1,5,3,0,1,4,0};
Console.WriteLine($"Given Array: [0,1,5,3,0,1,4,0].\nExpected Output: [0,0,1,5,3,0,0,1]");
Console.Write("Output: ");
DuplicateZeros.DuplicateZero(array);

Console.WriteLine("\n\n02. Merge Two Sorted Array");
int[] array1 = new int[8] {1,2,3,4,5,0,0,0};
int[] array2 = new int[3] {3,4,5};
int m = 5, n = 3;
Console.WriteLine($"Given Array1: [1,2,3,4,5,0,0,0].\nGiven Array2: [3,4,5].\nExpected Output: [1,2,3,3,4,4,5,5]");
MergeTwoSortedArray.MergeSortedArray(array1, m, array2, n);

Console.WriteLine("\n\n03. Remove Given Value");
int[] arrayThree = new int[8] { 0, 1, 5, 3, 0, 1, 4, 0 };
int value = 0;
Console.WriteLine($"Given Array: [0,1,5,3,0,1,4,0].\nGiven Value: {value}.\nExpected Output: 5");
Console.Write("Output: ");
RemovegivenElementFromArray.Main(arrayThree, value);

Console.WriteLine("\n\n04. Remove Duplicate Value");
int[] arrayFour = new int[3] { 1,1,2 };
Console.WriteLine($"Given Array: [1,1,2].\nExpected Output: 2");
Console.Write("Output: ");
RemoveDuplicateValue.Main(arrayFour);

Console.ReadKey();