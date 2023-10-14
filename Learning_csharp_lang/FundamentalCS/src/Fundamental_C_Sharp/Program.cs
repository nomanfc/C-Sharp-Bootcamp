// See https://aka.ms/new-console-template for more information
using Fundamental_C_Sharp;

Console.WriteLine("::::::::::::::::- FUNDAMENTALS -::::::::::::::::::::");

Console.WriteLine("\n13. Out Keyword Output: ");
Console.WriteLine("\nArray : [10,20,30,40,5,-1,-50,-41,-40]");
OutKeyword.Out();

Console.WriteLine("\n12. Generic List Output: ");
List.ListGeneric();

Console.WriteLine("\n11. For Each Loop Output: ");
ForEachLoop.ForEach();

Console.WriteLine("\n10. Multi Dimentional Array Output: ");
MultiDimentionalArray.TwoDArray();

Console.WriteLine("\n09. Summation of an Array Output: ");
int[] nums = { 1, 2, 3, 4, 5, 8, 4, 6, 2, 1 };
Console.WriteLine("Array: [1, 2, 3, 4, 5, 8, 4, 6, 2, 1]");
Arrays.ArraySum(nums);

Console.WriteLine("\n08. Do While Loop Output: ");
DoWhileLoop.DoWhile();

Console.WriteLine("\n07. While Loop Output: ");
Console.WriteLine($"It will print 0 to 9 and coresponding number of a: ");
WhileLoop.UsingWhile();

Console.WriteLine("\n06. Switch Case Output (string): ");
int point = 5;
Console.WriteLine($"Point {point} is Grade: {SwitchCaseStatement.SwitchCase(point)}");

Console.WriteLine("\n05. Switch Case Output (character): ");
point = 10;
Console.WriteLine($"Point {point} is Grade: {SwitchCaseStatement.SwitchCase(point)}");

Console.WriteLine("\n04. Parsing String to Integer Output: ");
ParsingStringToInteger.ParseStringToInt();

Console.WriteLine("\n03. Methods Output: ");
int a = 10, b = 20;
Methods.VoidMethod("This is Void Method...!");
Console.WriteLine($"Integer Method: Multplication of {a} and {b} is {Methods.IntMethod(10, 20)}");

Console.WriteLine("\n02. Local Scope Variable Output: ");
LocalVariableScoping.ScopeTest();

Console.WriteLine("\n01. Debugging Output: ");
Debugging.DebugTest();


Console.WriteLine("\nPress Enter to exit");
Console.Read();