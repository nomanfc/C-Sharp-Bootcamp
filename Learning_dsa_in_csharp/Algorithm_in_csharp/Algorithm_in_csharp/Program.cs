using Boyer_Moore_Voting_algo;

Console.WriteLine("::::::::::::::::::::::::!! Algorithms !!::::::::::::::::::::::");

Console.WriteLine("\n\n1. Boyer Moore Voting Algorithm\n");
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
}


Console.ReadLine();
