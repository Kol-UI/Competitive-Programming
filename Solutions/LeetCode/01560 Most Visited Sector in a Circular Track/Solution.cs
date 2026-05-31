// Most Visited Sector in a Circular Track
namespace CompetitiveProgramming.LeetCode.MostVisitedSectorinaCircularTrack;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> MostVisited(int n, int[] rounds)
    {
        var visited = new int[n + 1];

        visited[rounds[0]]++;

        for (var i = 1; i < rounds.Length; i++)
        {
            var from = rounds[i - 1] + 1;

            var to = rounds[i] < from ? rounds[i] + n : rounds[i];

            for (var j = from; j <= to; j++)
            {
                visited[(j > n) ? j - n : j]++;
            }
        }

        var max = visited.Max();

        var mostVisited = new List<int>(n);

        for (var i = 1; i <= n; i++)
        {
            if (visited[i] == max)
                mostVisited.Add(i);
        }

        return mostVisited;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Most Visited Sector in a Circular Track");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}