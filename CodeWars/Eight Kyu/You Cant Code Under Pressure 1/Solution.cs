// You Can't Code Under Pressure #1

// Code as fast as you can! You need to double the integer and return it.


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.YouCantCodeUnderPressure1
{
    public class Solution
    {
        public static int DoubleInteger(int n)
        {
            return n*2;
        }
    }

    public class Test
    {
        public static bool[] TestYouCantCodeUnderPressure1()
        {
            int result1 = CodeWars.EightKyu.YouCantCodeUnderPressure1.Solution.DoubleInteger(2);
            int result2 = CodeWars.EightKyu.YouCantCodeUnderPressure1.Solution.DoubleInteger(4);
            int result3 = CodeWars.EightKyu.YouCantCodeUnderPressure1.Solution.DoubleInteger(-10);
            int result4 = CodeWars.EightKyu.YouCantCodeUnderPressure1.Solution.DoubleInteger(0);
            int result5 = CodeWars.EightKyu.YouCantCodeUnderPressure1.Solution.DoubleInteger(100);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 4),
                ResultTester.CheckResult<int>(result2, 8),
                ResultTester.CheckResult<int>(result3, -20),
                ResultTester.CheckResult<int>(result4, 0),
                ResultTester.CheckResult<int>(result5, 200)
            };
            return results;
        }
    }
}