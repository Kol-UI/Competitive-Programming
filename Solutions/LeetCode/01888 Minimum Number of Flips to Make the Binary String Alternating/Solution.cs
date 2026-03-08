// Minimum Number of Flips to Make the Binary String Alternating
namespace CompetitiveProgramming.LeetCode.MinimumNumberofFlipstoMaketheBinaryStringAlternating;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinFlips(string s)
    {
        int n = s.Length;
        if (n == 1) return 0;
        string doubleS = s + s;
        string patternA = GeneratePattern(n * 2, '0');
        string patternB = GeneratePattern(n * 2, '1');
        int result = n;
        int a = 0;
        int b = 0;
        for (int i = 0; i < doubleS.Length; i++)
        {
            if (doubleS[i] != patternA[i]) a++;
            if (doubleS[i] != patternB[i]) b++;

            if (i >= n)
            {
                if (doubleS[i - n] != patternA[i - n]) a--;
                if (doubleS[i - n] != patternB[i - n]) b--;
            }

            if (i >= n - 1)
            {
                result = Math.Min(result, Math.Min(a, b));
            }
        }
        return result;
    }

    private string GeneratePattern(int length, char start)
    {
        char[] arr = new char[length];
        char c = start;
        for (int i = 0; i < length; i++)
        {
            arr[i] = c;
            c = c == '0' ? '1' : '0';
        }
        return new string(arr);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinFlips("111000"), 2),
            ResultTester.CheckResult<int>(solution.MinFlips("010"), 0),
            ResultTester.CheckResult<int>(solution.MinFlips("1110"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Flips to Make the Binary String Alternating");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}