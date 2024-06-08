// Century From Year

/*
The first century spans from the year 1 up to and including the year 100, the second century - from the year 101 up to and including the year 200, etc.

Task
Given a year, return the century it is in.

Examples
1705 --> 18
1900 --> 19
1601 --> 17
2000 --> 20
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.CenturyFromYear
{
    public class Solution
	{
        public static int СenturyFromYear(int year)
        {
            return (year + 99) / 100;
        }
    }

    public class Test
    {
        public static bool[] TestCenturyFromYear()
        {
            int case1 = 18;
            int case2 = 19;
            int case3 = 17;
            int case4 = 20;
            
            int result1 = Solution.СenturyFromYear(1705);
            int result2 = Solution.СenturyFromYear(1900);
            int result3 = Solution.СenturyFromYear(1601);
            int result4 = Solution.СenturyFromYear(2000);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, case1),
                ResultTester.CheckResult<int>(result2, case2),
                ResultTester.CheckResult<int>(result3, case3),
                ResultTester.CheckResult<int>(result4, case4)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Centure From Year 1");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Test.TestCenturyFromYear());
        }
    }
}