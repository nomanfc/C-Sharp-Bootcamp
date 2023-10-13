﻿// See https://aka.ms/new-console-template for more information
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