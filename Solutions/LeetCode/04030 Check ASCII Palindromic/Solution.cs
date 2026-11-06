// Check ASCII Palindromic
namespace CompetitiveProgramming.LeetCode.CheckASCIIPalindromic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool IsPalindromic(string s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            if (!ArePalindromic(s[i], s[s.Length - 1 - i])) return false;
        }
        if (s.Length % 2 == 1)
        {
            var s0 = CharToBinary(s[s.Length / 2]);
            for (int i = 0; i < s0.Length / 2; i++)
            {
                if (s0[i] != s0[s0.Length - 1 - i]) return false;
            }
        }
        return true;
    }

    private bool ArePalindromic(char ch0, char ch1)
    {
        var s0 = CharToBinary(ch0);
        var s1 = CharToBinary(ch1);
        for (int i = 0; i < s0.Length; i++)
        {
            if (s0[i] != s1[s1.Length - 1 - i]) return false;
        }
        return true;
    }

    private int[] CharToBinary(char ch)
    {
        var rs = new int[8];
        var n = (int)ch;
        var index = rs.Length - 1;
        while (n > 0)
        {
            var digit = n % 2;
            rs[index] = digit;
            index--;
            n /= 2;
        }
        return rs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.IsPalindromic("ff"), true),
            ResultTester.CheckResult<bool>(solution.IsPalindromic("leet"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check ASCII Palindromic");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}