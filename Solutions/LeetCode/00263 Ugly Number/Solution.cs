// Ugly Number

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.UglyNumber
{
    public class Solution
    {
        public bool IsUgly(int n)
        {
            if (n <= 0)
            {
                return false;
            }

            n = ReduceByFactor(n, 2);
            n = ReduceByFactor(n, 3);
            n = ReduceByFactor(n, 5);

            return n == 1;
        }

        private int ReduceByFactor(int num, int factor)
        {
            while (num % factor == 0)
            {
                num /= factor;
            }
            return num;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Ugly Number");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}