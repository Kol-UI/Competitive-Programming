// Minimum Number of Flips to Reverse Binary String
namespace CompetitiveProgramming.LeetCode.MinimumNumberofFlipstoReverseBinaryString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumFlips(int n)
    {
        var bits = GetBits(n);
        var result = 0;
        for (int i = 0; i < bits.Count / 2; i++)
        {
            if (bits[i] != bits[bits.Count - 1 - i]) result += 2;
        }
        return result;
    }

    private List<int> GetBits(int n)
    {
        var result = new List<int>();
        while (n > 0)
        {
            result.Add(n % 2);
            n /= 2;
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumFlips(7), 0),
            ResultTester.CheckResult<int>(solution.MinimumFlips(10), 4)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Flips to Reverse Binary String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}