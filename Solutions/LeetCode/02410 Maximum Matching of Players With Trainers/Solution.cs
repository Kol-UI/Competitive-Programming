// Maximum Matching of Players With Trainers
namespace CompetitiveProgramming.LeetCode.MaximumMatchingofPlayersWithTrainers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players, Comparer<int>.Create((a, b) => b.CompareTo(a)));
        Array.Sort(trainers, Comparer<int>.Create((a, b) => b.CompareTo(a)));
        int matches = 0;
        for (int i = 0, j = 0; i < players.Length && j < trainers.Length; ++i)
        {
            if (players[i] <= trainers[j])
            {
                matches++;
                j++;
            }
        }
        return matches;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MatchPlayersAndTrainers(new int[]{4,7,9}, new int[]{8,2,5,8}), 2),
            ResultTester.CheckResult<int>(solution.MatchPlayersAndTrainers(new int[]{1,1,1}, new int[]{10}), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Matching of Players With Trainers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}