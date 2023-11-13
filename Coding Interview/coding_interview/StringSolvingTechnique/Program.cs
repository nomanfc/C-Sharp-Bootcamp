////////////////////// Coding InterView - String Solving ////////////////////


using StringSolvingTechnique;

Console.WriteLine("01. String Reverse:");
StringReverse.Main();

Console.WriteLine("\n\n02. String pallingdrom:");
string input = "radar radar";
Console.WriteLine("Input: " + input);
Console.WriteLine("Pallingdrom: " + Palingdrom.Main(input));

Console.WriteLine("\n\n03. Reverse Integer:");
int number = -1234567890;
Console.WriteLine("Input: " + number);
Console.WriteLine("Output: " + ReverseInteger.Main(number));

Console.WriteLine("\n\n04. LCS : Longest Common Subsequence:");
string inputOne = "acccaaaacaa";
string inputTwo = "ccaascccaaa";
Console.WriteLine("Inputs: " + inputOne + " & " + inputTwo);
Console.WriteLine(LCS.Main(inputOne, inputTwo));

Console.ReadKey();
