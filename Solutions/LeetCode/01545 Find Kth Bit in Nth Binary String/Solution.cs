// Find Kth Bit in Nth Binary String

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindKthBitinNthBinaryString
{
    public class Solution
    {
        public char FindKthBit(int n, int k)
        {
            var sb = new StringBuilder("0");
            for(int i = 1; i < n; i++)
            {
                var reverse = ReverseInvert(sb.ToString());
                sb.Append($"1{reverse}");
            }
            return sb[--k];
        }

        public string ReverseInvert(string s)
        {
            var sb = new StringBuilder();
            for(int i = s.Length - 1; i >= 0; i--)
            {
                sb.Append(s[i] == '0' ? '1' : '0');
            }
            return sb.ToString();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var solution = new Solution();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<char>(solution.FindKthBit(3, 1), '0'),
                ResultTester.CheckResult<char>(solution.FindKthBit(4, 11), '1')
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Kth Bit in Nth Binary String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}