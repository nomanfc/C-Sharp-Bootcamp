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
int[] arrayThree = new int[10] { 1, 1, 2, 2, 3, 5, 7, 7, 7, 8 };
Console.WriteLine($"Given Array: [1,1,2,2,3,5,7,7,7,8].\nValue: 7");
Console.Write("Output: ");
RemovegivenElementFromArray.Main(arrayThree, 7);

Console.WriteLine("\n\n04. Remove Duplicate Value");
int[] arrayFour = new int[10] { 1,1,2,2,3,5,7,7,7,8 };
Console.WriteLine($"Given Array: [1,1,2,2,3,5,7,7,7,8].");
Console.Write("Output: ");
RemoveDuplicateValue.Main(arrayFour);

Console.WriteLine("\n\n05. Search if N and It's Double Exist");
int[] arrayFive = new int[6] { 0,2,9,5,3,11 };
Console.WriteLine($"Given Array: [0,2,9,5,3,11].");
Console.Write("Output: ");
Console.WriteLine(SearchingDoubleNumber.Main(arrayFive));
Console.WriteLine();
int[] arrayFiveOne = new int[6] { 0, 2, 9, 4, 3, 11 };
Console.WriteLine($"Given Array: [0,2,9,4,3,11].");
Console.Write("Output: ");
Console.WriteLine(SearchingDoubleNumber.Main(arrayFiveOne));

Console.WriteLine("\n\n06. Valid Mountain Array");

int[] arraySix = new int[6] { 0, 2, 9, 5, 3, 11 };
Console.WriteLine($"Given Array: [0,2,9,5,3,11].");
Console.Write("Output: ");
Console.WriteLine(ValidMountain.Main(arraySix));
Console.WriteLine();

int[] arraySixOne = new int[10] { 0,1,2,4,10,9,6,3,1,0 };
Console.WriteLine($"Given Array: [0,1,2,4,10,9,6,3,1,0].");
Console.Write("Output: ");
Console.WriteLine(ValidMountain.Main(arraySixOne));

Console.WriteLine("07. Even index squared Array");
int[] arraySeven = new int[10] { 0, 1, 2, 4, 10, 9, 6, 3, 1, 0 };
EvenSquaredArray.Main(arraySeven);

Console.WriteLine("\n\n08. Relace Array Items with Right max element");
int[] arrayEight = new int[10] { 0, 1, 2, 4, 10, 9, 6, 3, 1, 5 };
Console.WriteLine("Array: [ 0, 1, 2, 4, 10, 9, 6, 3, 1, 0 ]");
ReplaceElementWithRightMax.Main(arrayEight);

Console.WriteLine("\n\n09. Move Zero To End of the Array");
int[] arrayNine = new int[10] { 0, 1, 2, 0, 0, 0, 6, 3, 1, 5 };
Console.WriteLine("Array: [ 0, 1, 2, 0, 0, 0, 6, 3, 1, 5]");
MoveZerosToEnd.Main(arrayNine);

Console.WriteLine("\n\n10. Height Checking");
int[] heights = new int[10] { 1, 1, 2, 2, 3, 1, 6, 3, 1, 5 };
Console.WriteLine("Array: [1, 1, 2, 2, 3, 1, 6, 3, 1, 5 ]");
HeightChecking.Main(heights);

Console.ReadKey();