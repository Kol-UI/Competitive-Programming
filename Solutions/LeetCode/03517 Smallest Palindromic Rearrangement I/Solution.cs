// Smallest Palindromic Rearrangement I
namespace CompetitiveProgramming.LeetCode.SmallestPalindromicRearrangementI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string SmallestPalindrome(string input)
    {
        if (input.Length == 1) return input;

        int half = input.Length / 2;
        char[] chars = input.Substring(0, half).ToCharArray();

        Array.Sort(chars);
        string ascending = new string(chars);
        Array.Reverse(chars);
        string descending = new string(chars);

        if (input.Length % 2 == 1)
        {
            return ascending + input[half] + descending;
        }
        else
        {
            return ascending + descending;
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(solution.SmallestPalindrome("z"), "z"),
            ResultTester.CheckResult<string>(solution.SmallestPalindrome("daccad"), "acddca"),
            ResultTester.CheckResult<string>(solution.SmallestPalindrome("babab"), "abbba")
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Palindromic Rearrangement I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}