// Count Symmetric Integers



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountSymmetricIntegers
{
    public class Solution
    {
        public static int CountSymmetricIntegers(int low, int high)
        {
            int result = 0;
            for(int j = low; j <= high; j++)
            {
                var stringNum = j.ToString();
                if(stringNum.Length%2 == 0)
                {
                    var firstNumString = stringNum.Substring(0, stringNum.Length / 2);
                    var secondNumString = stringNum.Substring(stringNum.Length / 2);
                    int firstNum = 0;
                    int secondNum = 0;

                    for(int i = 0; i < firstNumString.Length; i++)
                    {
                        firstNum += int.Parse(firstNumString[i].ToString());
                    }

                    for(int i = 0; i < secondNumString.Length; i++)
                    {
                        secondNum += int.Parse(secondNumString[i].ToString());
                    }

                    if(firstNum == secondNum)
                        result++;
                }
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountSymmetricIntegers(1, 100), 9),
                ResultTester.CheckResult<int>(Solution.CountSymmetricIntegers(1200, 1230), 4),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2843");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}