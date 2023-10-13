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

if (operation == "A" || operation == "a") Console.WriteLine($"{numberOne} + {numberTwo} = {Addition(numberOne, numberTwo)}");
else if (operation == "S" || operation == "s") Console.WriteLine($"{numberOne} - {numberTwo} = {Subtraction(numberOne, numberTwo)}");
else if (operation == "M" || operation == "m") Console.WriteLine($"{numberOne} * {numberTwo} = {Multiplication(numberOne, numberTwo)}");
else if (operation == "D" || operation == "d") Console.WriteLine($"{numberOne} / {numberTwo} = {Division(numberOne, numberTwo)}");
else if (operation == "R" || operation == "r") Console.WriteLine($"{numberOne} % {numberTwo} = {Modulo(numberOne, numberTwo)}");
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

void InvalidOpearation()
{
    Console.WriteLine("Invalid Operation");
}



