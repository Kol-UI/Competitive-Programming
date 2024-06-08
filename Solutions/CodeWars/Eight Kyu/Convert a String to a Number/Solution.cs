using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertaStringtoaNumber
{
    /*
        We need a function that can transform a string into a number. What ways of achieving this do you know?
        Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

        Examples
        "1234" --> 1234
        "605"  --> 605
        "1405" --> 1405
        "-7" --> -7
    */
	public class Solution
	{
        // Error if null
        public static int StringToNumber(String str)
        {
            int result = 0;
            return result = Convert.ToInt32(str);
        }

        // No error if null (return 0)
        public static int StringToNumberClever(String str)
        {
            return (int.Parse(str));
        }
    }

    public class Test
    {
        public static bool[] TestConvertaStringtoaNumber()
        {
            string case1ConvertaStringtoaNumber = "1234";
            int resultcase1ConvertaStringtoaNumber = Solution.StringToNumber(case1ConvertaStringtoaNumber);
            int resultcase1ConvertaStringtoaNumberClever = Solution.StringToNumberClever(case1ConvertaStringtoaNumber);
            string case2ConvertaStringtoaNumber = "605";
            int resultcase2ConvertaStringtoaNumber = Solution.StringToNumber(case2ConvertaStringtoaNumber);
            int resultcase2ConvertaStringtoaNumberClever = Solution.StringToNumberClever(case2ConvertaStringtoaNumber);
            string case3ConvertaStringtoaNumber = "1405";
            int resultcase3ConvertaStringtoaNumber = Solution.StringToNumber(case3ConvertaStringtoaNumber);
            int resultcase3ConvertaStringtoaNumberClever = Solution.StringToNumberClever(case3ConvertaStringtoaNumber);
            string case4ConvertaStringtoaNumber = "-7";
            int resultcase4ConvertaStringtoaNumber = Solution.StringToNumber(case4ConvertaStringtoaNumber);
            int resultcase4ConvertaStringtoaNumberClever = Solution.StringToNumberClever(case4ConvertaStringtoaNumber);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultcase1ConvertaStringtoaNumber, 1234),
                ResultTester.CheckResult<int>(resultcase2ConvertaStringtoaNumber, 605),
                ResultTester.CheckResult<int>(resultcase3ConvertaStringtoaNumber, 1405),
                ResultTester.CheckResult<int>(resultcase4ConvertaStringtoaNumber, -7),
                ResultTester.CheckResult<int>(resultcase1ConvertaStringtoaNumberClever, 1234),
                ResultTester.CheckResult<int>(resultcase2ConvertaStringtoaNumberClever, 605),
                ResultTester.CheckResult<int>(resultcase3ConvertaStringtoaNumberClever, 1405),
                ResultTester.CheckResult<int>(resultcase4ConvertaStringtoaNumberClever, -7),
                ResultTester.CheckResult<int>(resultcase1ConvertaStringtoaNumber, resultcase1ConvertaStringtoaNumberClever),
                ResultTester.CheckResult<int>(resultcase2ConvertaStringtoaNumber, resultcase2ConvertaStringtoaNumberClever),
                ResultTester.CheckResult<int>(resultcase3ConvertaStringtoaNumber, resultcase3ConvertaStringtoaNumberClever),
                ResultTester.CheckResult<int>(resultcase4ConvertaStringtoaNumber, resultcase4ConvertaStringtoaNumberClever),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a String a Number 1");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestConvertaStringtoaNumber());
        }
    }
}