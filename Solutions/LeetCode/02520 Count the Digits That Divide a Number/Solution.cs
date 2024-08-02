// Count the Digits That Divide a Number


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CounttheDigitsThatDivideaNumber
{
    public class Solution
    {
        public static int CountDigits(int num)
        {
            int count = 0,x;
            x = num;

            while(x != 0)
            {
                if(num % (x % 10) == 0)
                count++;
                x = x/10;
            }
            
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountDigits(7), 1),
                ResultTester.CheckResult<int>(Solution.CountDigits(121), 2),
                ResultTester.CheckResult<int>(Solution.CountDigits(1248), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2520");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}