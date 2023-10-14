// See https://aka.ms/new-console-template for more information
using Fundamental_C_Sharp;

Console.WriteLine("::::::::::::::::- FUNDAMENTALS -::::::::::::::::::::");
Console.WriteLine("\n01. Debugging Output: ");
Debugging.DebugTest();

Console.WriteLine("\n02. Local Scope Variable Output: ");
LocalVariableScoping.ScopeTest();

Console.WriteLine("\n03. Methods Output: ");
int a = 10, b = 20;
Methods.VoidMethod("This is Void Method...!");
Console.WriteLine($"Integer Method: Multplication of {a} and {b} is {Methods.IntMethod(10, 20)}");

Console.WriteLine("\n04. Parsing String to Integer Output: ");
ParsingStringToInteger.ParseStringToInt();

Console.WriteLine("\n05. Switch Case Output (string): ");
int point = 5;
Console.WriteLine($"Point {point} is Grade: {SwitchCaseStatement.SwitchCase(point)}");

Console.WriteLine("\n06. Switch Case Output (character): ");
point = 10;
Console.WriteLine($"Point {point} is Grade: {SwitchCaseStatement.SwitchCase(point)}");

Console.WriteLine("\n07. While Loop Output: ");
Console.Write($"It will print 0 to 9: ");
WhileLoop.UsingWhile();



Console.WriteLine("\nPress Enter to exit");
Console.Read();