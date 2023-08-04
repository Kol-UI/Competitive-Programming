using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AddTwoIntegers
{
    public class Solution
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int Case1_2235 = Solution.Sum(12, 5);

            // Case 2
            int Case2_2235 = Solution.Sum(-10, 4);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_2235, 17),
                ResultTester.CheckResult<int>(Case2_2235, -6)
            };
            return results;
        }
    }
}

