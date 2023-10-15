using System.Security.Cryptography;

Console.WriteLine(" ::::::::::::::::::::- ToDo List Application -::::::::::::::::::::::");

Console.WriteLine("\n Hello, welcome to Todo Application..\n");
Console.WriteLine(" What do you want to do?\n");
Console.WriteLine(" [S]ee all TODOs");
Console.WriteLine(" [A]dd new TODO");
Console.WriteLine(" [R]emove a TODO");
Console.WriteLine(" [E]xit");

string chooseOption;
bool varification;
List<string> todoList = new();

MainApp();

//Methods here

void MainApp()
{
    Console.Write("\n Choose an option: ");
    chooseOption = Console.ReadLine();
    varification = isInsertedOptionValid(chooseOption.ToUpper());

    CheckVerification();
    Console.WriteLine("Main");
    switch (chooseOption.ToUpper())
    {
        case "S":
            DisplayTodo();
            break;

        case "A":
            AddItem();
            break;

        default:
            Console.WriteLine("Hi  ads");
            break;
    }
}

//checking choosed option is valid or not
bool isInsertedOptionValid(string option)
{
    string op = option.ToUpper();
    switch (op)
    {
        case "S":
            return true;
        case "A":
            return true;
        case "R":
            return true;
        case "E":
            return true;
        default:
            return false;
    }
}

//display todo
void DisplayTodo()
{
    if (todoList.Count == 0)
    {
        Console.WriteLine("Todo List is empty");
    }
    else
    {
        foreach(string todo in todoList)
        {
            Console.WriteLine($"{todoList.IndexOf(todo)+1}.{todo}");
        }
    }
}

//add item
void AddItem()
{
    Console.WriteLine("Enter Description: ");
    string item = Console.ReadLine();

    if (item.Length <= 0)
    {
        Console.WriteLine("Item must not be null");
    }
    else if(todoList.Contains(item))
    {
        Console.WriteLine("Item already exist in the list.");
    }
    else
    {
        todoList.Add(item);
    }

    MainApp();
}

//check verification
void CheckVerification()
{
    while (!varification)
    {
        Console.Write("\n Invalid Option. Please Enter valid Option: ");
        chooseOption = Console.ReadLine();
        varification = isInsertedOptionValid(chooseOption);
    }

}





Console.ReadKey();