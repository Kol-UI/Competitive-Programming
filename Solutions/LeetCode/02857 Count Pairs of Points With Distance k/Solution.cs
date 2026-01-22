// Count Pairs of Points With Distance k
namespace CompetitiveProgramming.LeetCode.CountPairsofPointsWithDistancek;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountPairs(IList<IList<int>> coordinates, int k)
    {
        Dictionary<int, Dictionary<int, int>> counts = new();
        int result = 0;
        for (int i = 0; i < coordinates.Count; i++)
        {
            IList<int> point = coordinates[i];
            int x1 = point[0], y1 = point[1];

            for (int j = k; j >= 0; j--)
            {
                int x2 = x1 ^ j;
                int y2 = y1 ^ (k - j);

                if (counts.ContainsKey(x2) && counts[x2].ContainsKey(y2))
                    result += counts[x2][y2];
            }

            if (!counts.ContainsKey(x1))
            {
                counts.Add(x1, new Dictionary<int, int>());
            }

            if (!counts[x1].ContainsKey(y1))
            {
                counts[x1].Add(y1, 0);
            }

            counts[x1][y1] += 1;
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Pairs of Points With Distance k");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}