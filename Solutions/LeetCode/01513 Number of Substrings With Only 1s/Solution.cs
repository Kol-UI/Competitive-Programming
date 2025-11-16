// Number of Substrings With Only 1s
namespace CompetitiveProgramming.LeetCode.NumberofSubstringsWithOnlyOnes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumSub(string s)
    {
        long result = 0;
        long prime = 1_000_000_007;
        var n = s.Length;

        for (long i = 0; i < n; ++i)
        {
            if (s[(int)i] == '1')
            {
                var start = i;
                var end = i;
                while (end < n && s[(int)end] == '1')
                {
                    ++end;
                }

                var temp = (end - start);
                result = (result + temp * (temp + 1) / 2) % prime;

                i = end;
            }
        }

        return (int)result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumSub("0110111"), 9),
            ResultTester.CheckResult<int>(solution.NumSub("101"), 2),
            ResultTester.CheckResult<int>(solution.NumSub("111111"), 21),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Substrings With Only 1s");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}