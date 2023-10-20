using OOP_concepts_with_chsarp;

Console.WriteLine(":::::::::::::::::::::- OOP CONCEPTS -::::::::::::::::::::");

var date = new DateTime(2023, 10, 18, 13, 52, 33 );
Console.WriteLine($"\nTodaty is: {date.DayOfWeek}. {date}");

//:::::::::::::::::::::::::::DateTime struct/class:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n01. Use of DateTime struct: ");
DateTimeStruct.Main();

//:::::::::::::::::::::::::::Custom Constructor:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n02. Use of custom constructor: ");
Console.WriteLine("\nTwo objects have been created from Class Rectangle");
var rectangleOne = new Rectangle(5, 10);
Console.WriteLine($"\nObjectOne: Height: {rectangleOne.Height} Width: {rectangleOne.Width}");
Console.WriteLine($"ObjectOne: Area is {rectangleOne.CalculateArea()} and Circumference is {rectangleOne.CalculateCircumference()}");

var rectangleTwo = new Rectangle(15, 100);
Console.WriteLine($"\nObjectTwo: Height: {rectangleTwo.Height} Width: {rectangleTwo.Width}");
Console.WriteLine($"ObjectTwo: Area is {rectangleTwo.CalculateArea()} and Circumference is {rectangleTwo.CalculateCircumference()}");

//:::::::::::::::::::::::::::OverLoadig Method:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n03. Method Overloading: ");

var objectOne = new MethodOverloading("Asif Ul-Islam", new DateTime(2023, 10, 25, 14, 50, 0));
objectOne.Display();

Console.WriteLine("\nTime has been reschudled...");
objectOne.ReSchedule(new DateTime(2023,10,26,14,50,0));
objectOne.Display();

Console.WriteLine("\nTime has been reschudled...");
objectOne.ReSchedule(10, 28);
objectOne.Display();

Console.WriteLine("\nSchedule has been overwritten...");
objectOne.OverwriteReSchedule(1, 2);
objectOne.Display();

//:::::::::::::::::::::::::::OverLoadig Constructor:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n04. Constructor Overloading: ");

var objectCO = new ConstructorOverloading("Asif Ul-Islam", DateTime.Now);
objectCO.Display();

Console.WriteLine("\nPassing only name parameter to Constructor");
var objectCO2 = new ConstructorOverloading("Asif Ul-Islam");
objectCO2.Display();
Console.WriteLine("Default date has been added to schedule");

//:::::::::::::::::::::::::::Expression Bodied Method:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n05. Expression Bodied Method ( => )");
var obj = new ExpressionBodiedMethod(5, 10);
Console.WriteLine($"ObjectOne: Height: {obj.Height} Width: {obj.Width}");
Console.WriteLine($"ObjectOne: Area is {obj.CalculateArea()} and Circumference is {obj.CalculateCircumference()}");

//:::::::::::::::::::::::::::Constructor Validation:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n02. Use of custom constructor: ");
Console.WriteLine("Two objects have been created from Class Rectangle");
var objOne = new AddingValidationInConstructorParameter(5, 10);
Console.WriteLine($"ObjectOne: Area is {objOne.CalculateArea()} and Circumference is {objOne.CalculateCircumference()}");

var objTwo = new AddingValidationInConstructorParameter(15, 100);
Console.WriteLine($"ObjectTwo: Area is {objTwo.CalculateArea()} and Circumference is {objTwo.CalculateCircumference()}");


Console.ReadKey();