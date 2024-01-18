// Number of Senior Citizens


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofSeniorCitizens
{
    public class Solution 
    {
        public static int CountSeniors(string[] details) 
        {
            return details.Count(d => int.Parse(d.Substring(11, 2)) > 60);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountSeniors(new string[]{"7868190130M7522","5303914400F9211","9273338290F4010"}), 2),
                ResultTester.CheckResult<int>(Solution.CountSeniors(new string[]{"1313579440F2036","2921522980M5644"}), 0),
            };
            return results;
        }
    }
}