// Concatenation of Consecutive Binary Numbers
namespace CompetitiveProgramming.LeetCode.ConcatenationofConsecutiveBinaryNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ConcatenatedBinary(int n)
    {
        List<char> all = new List<char>();

        for (int i = n; i > 0; i--)
        {
            int temp = i;
            while (temp > 0)
            {
                all.Add((temp & 1) == 1 ? '1' : '0');
                temp >>= 1;
            }
        }
        all.Reverse();
        string num = String.Join("", all);
        int result = 0;
        int modulo = (int)Math.Pow(10, 9) + 7;
        for (int i = 0; i < num.Length; i++)
        {
            result <<= 1;
            result |= (all[i] - '0');
            result %= modulo;
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
            ResultTester.CheckResult<int>(solution.ConcatenatedBinary(1), 1),
            ResultTester.CheckResult<int>(solution.ConcatenatedBinary(3), 27),
            ResultTester.CheckResult<int>(solution.ConcatenatedBinary(12), 505379714),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Concatenation of Consecutive Binary Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}