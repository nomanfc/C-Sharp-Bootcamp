using Algorithm_in_csharp;
using Boyer_Moore_Voting_algo;

Console.WriteLine("::::::::::::::::::::::::!! Algorithms !!::::::::::::::::::::::");

/*Console.WriteLine("\n\n1. Boyer Moore Voting Algorithm\n");
int[] number = { 0, 0, 0, 0, 0, 2, 2, 0, 1, 2, 1, 0 };
Console.WriteLine("Array : [0, 0, 0, 0, 0, 2, 2, 0, 1, 2, 1, 0]");
int winner = BoyerMoreVotingAlgo.VotingAlgo(number);
if (winner > -1)
{
    Console.WriteLine($"Winner is : {winner}");
}
else
{
    Console.WriteLine("No Winner Found!!");
}*/

/*Console.WriteLine("\n2. Quick Find Algorithm");

Console.Write("\nEnter Number Of Objects: ");

int N = Convert.ToInt32(Console.ReadLine());

QuickFindAlgorithm QF = new(N);

QF.PrintValue();

while (N > 0)
{
    Console.Write("\nEnter P: ");
    int p = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Q: ");
    int q = Convert.ToInt32(Console.ReadLine());

    if (!QF.Connected(p, q))
    {
        QF.Union(p, q);
        Console.WriteLine($"\nConnecting {p} and {q}");
    }
    else
    {
        Console.WriteLine("\nAlready Connected");
    }

    QF.PrintValue();
}

Console.ReadLine();
*/

Console.WriteLine("\n3. Union Find Algorithm");

Console.Write("\nEnter Number Of Objects: ");

int N = Convert.ToInt32(Console.ReadLine());

UnionFindAlgorithm UF = new(N);

UF.PrintValue();

while (N > 0)
{
    Console.Write("\nEnter P: ");
    int p = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter Q: ");
    int q = Convert.ToInt32(Console.ReadLine());

    if (!UF.Connected(p, q))
    {
        UF.Union(p, q);
        Console.WriteLine($"\nConnecting {p} and {q}");
    }
    else
    {
        Console.WriteLine("\nAlready Connected");
    }

    UF.PrintValue();
}

Console.ReadLine();
