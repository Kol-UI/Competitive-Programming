// Minimum Array End

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumArrayEnd
{
    public class Solution
    {
        public long MinEnd(int n, int x)
        {
            bool[] bitMask = new bool[64];
            string binaryNumber = Convert.ToString(x, 2);

            int len = binaryNumber.Length;
            int i = 64;
            while (--len >= 0)
            {
                bitMask[--i] = binaryNumber[len] == '1';
            }

            string bitMaskNumber = Convert.ToString(n - 1, 2);

            len = bitMaskNumber.Length - 1;
            i = 64;
            StringBuilder stringBuilder = new StringBuilder();

            while (--i >= 0)
            {
                if (!bitMask[i] && len >= 0)
                {
                    bitMask[i] = bitMaskNumber[len--] == '1';
                }

                stringBuilder.Insert(0, bitMask[i] ? '1' : '0');
            }

            return Convert.ToInt64(stringBuilder.ToString(),2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(solution.MinEnd(3,4), 6),
                ResultTester.CheckResult<long>(solution.MinEnd(2,7), 15)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Array End");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}