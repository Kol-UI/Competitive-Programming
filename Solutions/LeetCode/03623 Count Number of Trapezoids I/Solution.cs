// Count Number of Trapezoids I
namespace CompetitiveProgramming.LeetCode.CountNumberofTrapezoidsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountTrapezoids(int[][] points)
    {
        var mod = 1000000007;
        var dicValues = new Dictionary<int, List<int>>();

        foreach (var point in points)
        {
            if (!dicValues.ContainsKey(point[1]))
            {
                dicValues[point[1]] = new List<int>();
            }
            dicValues[point[1]].Add(point[0]);
        }

        var pre = 0L;
        var result = 0L;

        foreach (var value in dicValues.Values)
        {
            var cnt = value.Count;
            var combo = (long)cnt * (cnt - 1) / 2 % mod;
            result = (result + pre * combo) % mod;
            pre = (pre + combo) % mod;
        }

        return (int)result % mod;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Number of Trapezoids I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}