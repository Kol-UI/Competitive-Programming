// Find The Least Frequent Digit
namespace CompetitiveProgramming.LeetCode.FindTheLeastFrequentDigit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int GetLeastFrequentDigit(int n)
    {
        int a = n;
        Dictionary<int, int> b = new Dictionary<int, int>();
        while (a > 0)
        {
            int f = a % 10;
            if (!b.ContainsKey(f))
            {
                b.Add(f, 1);
            }
            else
            {
                b[f]++;
            }
            a = a / 10;
        }
        var c = b.OrderBy(b => b.Value).ThenBy(b => b.Key);
        var k = c.ElementAt(0);

        return k.Key;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.GetLeastFrequentDigit(1553322), 1),
            ResultTester.CheckResult<int>(solution.GetLeastFrequentDigit(723344511), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find The Least Frequent Digit");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}