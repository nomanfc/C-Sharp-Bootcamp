using DesignPatternOfCoding;

//TwoPointers Sum Problem
Console.WriteLine("01. Two Sum Problem");
int[] arr = { 1, 3, 4, 4, 5, 6, 7, 8, 9, 10, 10 };
int target = 19;
int[] result = TwoPointers.TwoSum(arr, target);
Console.WriteLine($"Geiven Array: [1, 3, 4, 4, 5, 6, 7, 8, 9, 10, 10] and Target is: {target}" );
Console.Write("Output: [");
foreach (int i in result)
{
    Console.Write(" " + i + " ");
}
Console.Write("]\n\n");