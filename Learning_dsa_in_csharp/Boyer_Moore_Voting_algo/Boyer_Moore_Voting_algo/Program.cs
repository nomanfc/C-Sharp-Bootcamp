using Boyer_Moore_Voting_algo;

Console.WriteLine("Boyer Moore Voting Algo");
int[] numbers = { 11,22,11,22,11,11,11,22 };
Console.WriteLine($"Array is :  [11,22,11,22,11,11,11,22]  \n{BoyerMoreVotingAlgo.VotingAlgo(numbers)} is the WINNER!!\n\n");
