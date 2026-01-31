// Maximum Binary String After Change
namespace CompetitiveProgramming.LeetCode.MaximumBinaryStringAfterChange;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MaximumBinaryString(string binary)
    {
        int zeros = 0;
        int firstZero = -1;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '0')
            {
                zeros++;
                if (firstZero == -1) firstZero = i;
            }
        }
        if (zeros < 2) return binary;
        StringBuilder sb = new();
        sb.Append('1', firstZero + (zeros - 1));
        sb.Append("0");
        sb.Append('1', binary.Length - sb.Length);
        return sb.ToString();
    }
}

public class Solution2
{
    public string MaximumBinaryString(string binary)
    {
        int n = binary.Length;
        int leadingOnes = 0;
        while (leadingOnes < n && binary[leadingOnes] == '1')
        {
            leadingOnes++;
        }

        int zeroCount = 0;
        for (int i = leadingOnes; i < n; i++)
        {
            if (binary[i] == '0')
            {
                zeroCount++;
            }
        }

        if (zeroCount <= 1)
        {
            return binary;
        }

        char[] result = new char[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = '1';
        }

        result[leadingOnes + zeroCount - 1] = '0';

        return new string(result);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        Solution2 solution2 = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MaximumBinaryString("000110"), "111011"),
            ResultTester.CheckResult<string>(solution.MaximumBinaryString("01"), "01"),
            ResultTester.CheckResult<string>(solution2.MaximumBinaryString("000110"), "111011"),
            ResultTester.CheckResult<string>(solution2.MaximumBinaryString("01"), "01"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Binary String After Change");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}