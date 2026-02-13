// Rank Teams by Votes
namespace CompetitiveProgramming.LeetCode.RankTeamsbyVotes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string RankTeams(string[] votes)
    {
        int[][] frequency = new int[26][];
        for (int i = 0; i < frequency.Length; i++)
        {
            frequency[i] = new int[votes[0].Length];
        }

        char[] teams = new char[26];
        for (int i = 0; i < teams.Length; i++)
        {
            teams[i] = (char)('A' + i);
        }

        foreach (string vote in votes)
        {
            for (int i = 0; i < vote.Length; i++)
            {
                frequency[vote[i] - 'A'][i]++;
            }
        }

        Array.Sort(teams, (a, b) =>
        {
            for (int i = 0; i < votes[0].Length; i++)
            {
                if (frequency[a - 'A'][i] != frequency[b - 'A'][i])
                {
                    return frequency[b - 'A'][i] - frequency[a - 'A'][i];
                }
            }
            return a - b;
        });

        string result = new string(teams.Take(votes[0].Length).ToArray());
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rank Teams by Votes");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}