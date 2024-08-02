// Maximum Difference by Remapping a Digit


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumDifferencebyRemappingaDigit
{
    public class Solution
    {
        public static int MinMaxDifference(int num)
        {
            var numberString = num.ToString();
            var numberArray = numberString.Select(c=>c.ToString()).ToArray();

            var i = 0;
            while(i < numberArray.Length - 1 && numberArray[i] == "9")
            {
                i++;
            }
            
            string number1 = numberString.Replace(numberArray[i],"9");
            string number2 = numberString.Replace(numberArray[0],"0");
            return int.Parse(number1) - int.Parse(number2);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinMaxDifference(11891), 99009),
                ResultTester.CheckResult<int>(Solution.MinMaxDifference(90), 99),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2566");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}