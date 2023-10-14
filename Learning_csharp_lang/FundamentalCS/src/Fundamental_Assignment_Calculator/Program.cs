// See https://aka.ms/new-console-template for more information
Console.WriteLine(":::::::::::::::::::::- CALCULATOR -:::::::::::::::::");

Console.Write("Enter First Number: ");
string inputOne = Console.ReadLine();
Console.Write("Enter Second Number: ");
string inputTwo = Console.ReadLine();

float numberOne = float.Parse(inputOne);
float numberTwo = float.Parse(inputTwo);

Console.WriteLine("\nSelect an Operation: ");
Console.WriteLine("[A]-ADDITION");
Console.WriteLine("[S]-SUBTRACTION");
Console.WriteLine("[M]-MULTIPLICATION");
Console.WriteLine("[D]-DIVISION");
Console.WriteLine("[R]-REMINDER");


Console.Write("\nEnter Options: ");
string operation = Console.ReadLine();

if (EqualCaseInsensitive(operation, "A")) DisplayResult(numberOne, numberTwo, Addition(numberOne, numberTwo), "+") ;
else if (EqualCaseInsensitive(operation, "S")) DisplayResult(numberOne, numberTwo, Subtraction(numberOne, numberTwo), "-");
else if (EqualCaseInsensitive(operation, "M")) DisplayResult(numberOne, numberTwo, Multiplication(numberOne, numberTwo), "*");
else if (EqualCaseInsensitive(operation, "D")) DisplayResult(numberOne, numberTwo, Division(numberOne, numberTwo), "/");
else if (EqualCaseInsensitive(operation, "R")) DisplayResult(numberOne, numberTwo, Modulo(numberOne, numberTwo), "%");
else InvalidOpearation();


float Addition(float a, float b)
{
    return a + b;
}

float Subtraction(float a, float b)
{
    return a - b;
}

float Multiplication(float a, float b)
{
    return a * b;
}

float Division(float a, float b)
{
    return a / b;
}

float Modulo(float a, float b)
{
    return a % b;
}

void DisplayResult(float a, float b, float result, string @operator)
{
    Console.WriteLine($"{a} {@operator} {b} = {result}");
    Console.WriteLine("\nPress Enter to exit");
}

bool EqualCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

void InvalidOpearation()
{
    Console.WriteLine("Invalid Operation");
}

Console.Read();

