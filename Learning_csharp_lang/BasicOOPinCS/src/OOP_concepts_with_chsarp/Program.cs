﻿using OOP_concepts_with_chsarp;

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
Console.WriteLine("\n06. Use of custom constructor: ");
Console.WriteLine("Two objects have been created from Class Rectangle");
var objOne = new AddingValidationInConstructorParameter(5, 10);
Console.WriteLine($"ObjectOne: Area is {objOne.CalculateArea()} and Circumference is {objOne.CalculateCircumference()}");

var objTwo = new AddingValidationInConstructorParameter(15, 100);
Console.WriteLine($"ObjectTwo: Area is {objTwo.CalculateArea()} and Circumference is {objTwo.CalculateCircumference()}");

//:::::::::::::::::::::::::::- Get And Set Method -:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n07. Get And Set Mehod: \n");
GetSetMethod objSeven = new GetSetMethod(5, 10);
Console.WriteLine($"Height Now: {objSeven.GetHeight()}");
Console.WriteLine($"Width Now: {objSeven.GetWidth()}");
Console.WriteLine($"\nArea Now: {objSeven.CalculateArea()}");

Console.WriteLine("\nSetting Height and Width to 10 20 : ");
objSeven.SetHeight(10);
objSeven.SetWidth(20);
Console.WriteLine($"Getting new height: {objSeven.GetHeight()}");
Console.WriteLine($"Getting new width: {objSeven.GetWidth()}");

Console.WriteLine($"\nNew Area Now: {objSeven.CalculateArea()}");

//:::::::::::::::::::::::::::- Properties -:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n08. Properties: \n");
Properties objEight = new Properties(5, 10);
Console.WriteLine($"Height Now: {objEight.Height}");
Console.WriteLine($"Width Now: {objEight.GetWidth()}");
Console.WriteLine($"\nArea Now: {objEight.CalculateArea()}");

Console.WriteLine("\nSetting Height and Width to 10 20 : ");
objEight.Height = 10;
objEight.SetWidth(20); 
Console.WriteLine($"Getting new height: {objEight.Height}");
Console.WriteLine($"Getting new width: {objEight.GetWidth()}");

Console.WriteLine($"\nNew Area Now: {objEight.CalculateArea()}");

//:::::::::::::::::::::::::::- Shorter version of Properties -:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n09. Shorter Way Properties: \n");
ModernWayOfGetSet objNine = new ModernWayOfGetSet(5, 10);
Console.WriteLine($"Height Now: {objNine.Height}");
Console.WriteLine($"Width Now: {objNine.Width}");
Console.WriteLine($"\nArea Now: {objNine.CalculateArea()}");

Console.WriteLine("\nSetting Height and Width to 10 20 : ");
objNine.Height = 100;
objNine.Width = 30;
Console.WriteLine($"Getting new height: {objNine.Height}");
Console.WriteLine($"Getting new width: {objNine.Width}");

Console.WriteLine($"\nNew Area Now: {objNine.CalculateArea()}");


/*::::::::::::::::::::::- Difference Between Fields and Properties -::::::::::::::::::::::::::::::::::::::::::::::
    Fields:
 *  # Like a variable [ _width, _height ]
 *  # Single Access Modifier [ public int _width, private int _height]
 *  # No separate Getter and Setter 
 *  # Can not be overridden in derived class
 *  # Should always be private
 *  
 *  Properties:
 *  # Like a Methods [ public int Height {} ]
 *  # Separate Access Modifier [ public int Width {get; private set;}]
 *  # getter or setter may be removed [ public int Width {get;} ]
 *  # Can be overridden in derived class
 *  # Can safely be public
 */

//:::::::::::::::::::::::::::- Object Initializers -:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n10. Object Initializers: \n");

Person objTen = new Person { Name = "Noman", YearOfBirth = 1997}; //_here we are using Object Initializers_//
var objTenTwo = new Person { Name = "Noman Fcb" }; //_here we are using Object Initializers_//

Console.WriteLine("Initializing only one Parameter Name. " +
    "\nYear of birth initiazed a random default value: \n");
Console.WriteLine($"Name: {objTenTwo.Name}");
Console.WriteLine($"Year of Birth: {objTenTwo.YearOfBirth}");

Console.WriteLine("\nBelow we are initialized two parameters: \n");
Console.WriteLine($"Name: {objTen.Name}");
Console.WriteLine($"Year of Birth: {objTen.YearOfBirth}");

Console.WriteLine("\nUpdating name and year of birth..... \n");
objTen.Name = "Abdullah Al Noman";
objTen.YearOfBirth = 1997;

Console.WriteLine($"Name Now: {objTen.Name}");
Console.WriteLine($"Year of Birth Now: {objTen.YearOfBirth}");

//:::::::::::::::::::::::::::- init in Object Initializers -:::::::::::::::::::::::::::::::::::::::::::::::::
Console.WriteLine("\n11. Init in Object Initializers: \n");

Student objEl = new Student("Abdullah Al Noman") { Name = "Noman" }; //_here we are using Object Initializers_//
Console.WriteLine($"Name: {objEl.Name} \n");
//objEl.Name = "Noman"; //we can't assign new value. init allows us to set name only during object initialization... 
Console.WriteLine("Here set name is private but only settable during object initializing. \nWe can't set new name after initialization");


//::::::::::::::::::::::::::- Properties of Static -:::::::::::::::::::::::::::::::::::::::::::::::::::::::::
/*
 *  # Static methods belong to a class as a whole, not to specific instance. [ ClassName.StaticMethod() ]
 *  # Static method can not use the instance data (values of fields or returned by properties)
 *  # Static class can not be instantiated, it only works as a container for methods. [ ClassName obj = new ClassName() will not work ]
 *  # Static c;asses can only contain static methods.
 *  # Non-Static classes can contain static methods.
 *  # If a private method does not use instance data, make it static.
 *  # const field will work in static class. They are implicitly static
 *  
*/


Console.ReadKey();