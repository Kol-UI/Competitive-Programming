// Convert Integer to the Sum of Two No-Zero Integers

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConvertIntegertotheSumofTwoNoZeroIntegers
{
    public class Solution
    {
        public int[] GetNoZeroIntegers(int n)
        {
            int a = 1;
            int b = n - 1;
            while (a < b)
            {
                if (a.ToString().IndexOf("0") < 0 && b.ToString().IndexOf("0") < 0)
                    return new int[]{a, b};
                a++;
                b--;
            }
            return new int[]{a, b};
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert Integer to the Sum of Two No-Zero Integers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}