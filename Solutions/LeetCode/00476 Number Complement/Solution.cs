// Number Complement

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberComplement
{
    public class Solution 
    {
        public static int FindComplement(int num) 
        {
            int mask = 1;

            while (mask < num) 
            {
                mask = (mask << 1) | 1;
            }

            return num ^ mask;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindComplement(5), 2),
                ResultTester.CheckResult<int>(Solution.FindComplement(1), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number Complement");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}