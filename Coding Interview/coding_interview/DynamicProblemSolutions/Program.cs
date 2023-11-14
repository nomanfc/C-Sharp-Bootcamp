using DynammicProblemSolutions;

Console.WriteLine("Dynamic Programming Solutions");

Console.WriteLine("\n01. LCS : Longest Common Subsequence:");
string inputOne = "acccaaaacaa";
string inputTwo = "ccaascccaaa";
Console.WriteLine("Inputs: " + inputOne + " & " + inputTwo);
Console.WriteLine(LCS.Main(inputOne, inputTwo));

Console.ReadKey();