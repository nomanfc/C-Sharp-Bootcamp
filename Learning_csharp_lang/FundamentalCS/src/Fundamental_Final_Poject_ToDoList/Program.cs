using System.Security.Cryptography;

Console.WriteLine(" ::::::::::::::::::::- ToDo List Application -::::::::::::::::::::::");

Console.WriteLine("\n Hello, welcome to Todo Application..\n");

Console.WriteLine(" What do you want to do?\n");
Console.WriteLine(" [S]ee all TODOs");
Console.WriteLine(" [A]dd new TODO");
Console.WriteLine(" [R]emove a TODO");
Console.WriteLine(" [C]lear ToDo List");
Console.WriteLine(" [E]xit");

string chooseOption;
bool varification;
List<string> todoList = new();

MainApp();

//Methods here

//Main Application
void MainApp()
{


    Console.Write("\nChoose an option: ");
    chooseOption = Console.ReadLine();
    varification = isInsertedOptionValid(chooseOption.ToUpper());

    CheckVerification();
    
    switch (chooseOption.ToUpper())
    {
        case "S":
            DisplayTodo();
            MainApp();
            break;

        case "A":
            AddItem();
            break;
        case "R":
            DisplayTodo();
            RemoveTodoByIndex();
            break;
        case "C":
            ClearTodo();
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
        case "C":
            return true;
        default:
            return false;
    }
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

//display todo
void DisplayTodo()
{
    Console.WriteLine("\nToDo List:");
    if (todoList.Count == 0)
    {
        Console.WriteLine("\nTodo List is empty\n");
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
    Console.Write("\nEnter Description: ");
    string item = Console.ReadLine();

    if (item.Length <= 0)
    {
        Console.WriteLine("\nItem must not be null\n");
        AddItem();
    }
    else if(todoList.Contains(item))
    {
        Console.WriteLine("\nItem already exist in the list.\n");
        AddItem();
    }
    else
    {
        todoList.Add(item);
        Console.WriteLine("\nItem has been added in the List");
        DisplayTodo();
        MainApp();
    }
}

//remove a todo
void RemoveTodoByIndex()
{
    Console.Write("\nEnter Index of Todo you want to remove: ");
    var removeIndex = Console.ReadLine();
    bool todoIndex = int.TryParse(removeIndex, out int result);

    if (!todoIndex)
    {
        Console.WriteLine("\nInput value must be integer");
        RemoveTodoByIndex();
    }
    else
    {
        int res = result - 1;

        if(res < 0 || res > todoList.Count-1) {
            Console.WriteLine("\nInvalid Index");
            RemoveTodoByIndex();
        }
        else
        {
            todoList.RemoveAt(res);
            Console.WriteLine("\nItem has been removed\n");
            DisplayTodo();
            MainApp();
        }
    }
}

//Clear Todo List
void ClearTodo()
{
    if(todoList.Count > 0)
    {
        todoList.Clear();
        Console.WriteLine("\nToDo List has been cleared");
        DisplayTodo();
        MainApp();
    }
    else
    {
        Console.WriteLine("\nList is Empty!");
    }
}

//Exit Method




Console.ReadKey();