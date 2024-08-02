// Largest 3-Same-Digit Number in String



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestSameDigitNumberinString
{
    public class Solution
    {
        public static string LargestGoodInteger(string num)
        {
            char? result = null;
            for (int i = 0; num.Length - 2 > i; i++)
            {
                if (num[i] == num[i+1] && num[i] == num[i+2])
                {
                    result = result >= num[i] ? result : num[i];
                    i += 2;
                }    
            }
            return $"{result}{result}{result}";
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.LargestGoodInteger("6777133339"), "777"),
                ResultTester.CheckResult<string>(Solution.LargestGoodInteger("2300019"), "000"),
                ResultTester.CheckResult<string>(Solution.LargestGoodInteger("42352338"), ""),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2264");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}