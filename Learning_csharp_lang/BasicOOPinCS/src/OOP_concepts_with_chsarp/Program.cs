using OOP_concepts_with_chsarp;

Console.WriteLine(":::::::::::::::::::::- OOP CONCEPTS -::::::::::::::::::::");

var date = new DateTime(2023, 10, 18, 13, 52, 33 );
Console.WriteLine($"\nTodaty is: {date.DayOfWeek}. {date}");

Console.WriteLine("\n01. Use of DateTime struct: ");
DateTimeStruct.Main();

Console.WriteLine("\n02. Use of custom constructor: ");
Console.WriteLine("\nTwo objects have been created from Class Rectangle");
var rectangleOne = new Rectangle(5, 10);
Console.WriteLine($"\nObjectOne: Height: {rectangleOne.Height} Width: {rectangleOne.Width}");
Console.WriteLine($"ObjectOne: Area is {rectangleOne.CalculateArea()} and Circumference is {rectangleOne.CalculateCircumference()}");

var rectangleTwo = new Rectangle(15, 100);
Console.WriteLine($"\nObjectTwo: Height: {rectangleTwo.Height} Width: {rectangleTwo.Width}");
Console.WriteLine($"ObjectTwo: Area is {rectangleTwo.CalculateArea()} and Circumference is {rectangleTwo.CalculateCircumference()}");


Console.ReadKey();