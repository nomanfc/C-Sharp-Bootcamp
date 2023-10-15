Console.WriteLine(" ::::::::::::::::::::- ToDo List Application -::::::::::::::::::::::");

Console.WriteLine("\n Hello, welcome to Todo Application..\n");
Console.WriteLine(" What do you want to do?\n");
Console.WriteLine(" [S]ee all TODOs");
Console.WriteLine(" [A]dd new TODO");
Console.WriteLine(" [R]emove a TODO");
Console.WriteLine(" [E]xit");

Console.Write("\n Choose an option: ");

string chooseOption;
bool varification;

chooseOption = Console.ReadLine();
varification = isInsertedOptionValid(chooseOption);

while (!varification)
{
    Console.Write("\n Invalid Option. Please Enter valid Option: ");
    chooseOption = Console.ReadLine();
    varification = isInsertedOptionValid(chooseOption);
}





//Methods here

//checking choosed option is valid or not
static bool isInsertedOptionValid(string option)
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




Console.ReadKey();