// Complement of Base 10 Integer

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ComplementofBaseTenInteger
{
    public class Solution
    {
        public static int BitwiseComplement(int number)
        {
            if (number == 0)
                return 1;

            return CalculateBitwiseComplement(number);
        }

        private static int CalculateBitwiseComplement(int number)
        {
            int complement = 0;
            int bitPosition = 0;

            while (number > 0)
            {
                if ((number & 1) == 0)
                {
                    complement += 1 << bitPosition;
                }

                number >>= 1;
                bitPosition++;
            }

            return complement;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.BitwiseComplement(5), 2),
                ResultTester.CheckResult<int>(Solution.BitwiseComplement(7), 0),
                ResultTester.CheckResult<int>(Solution.BitwiseComplement(10), 5)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Complement of Base 10 Integer");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}