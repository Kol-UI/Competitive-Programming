// Count Binary Substrings
namespace CompetitiveProgramming.LeetCode.CountBinarySubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        var count0 = 0;
        var count1 = 1;
        var result = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i - 1] == s[i])
            {
                count1++;
            }
            else
            {
                result += Math.Min(count0, count1);
                count0 = count1;
                count1 = 1;
            }
        }
        result += Math.Min(count0, count1);
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
            ResultTester.CheckResult<int>(solution.CountBinarySubstrings("00110011"), 6),
            ResultTester.CheckResult<int>(solution.CountBinarySubstrings("10101"), 4)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Binary Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}