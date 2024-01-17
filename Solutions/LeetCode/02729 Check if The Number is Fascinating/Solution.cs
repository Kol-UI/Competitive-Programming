// Check if The Number is Fascinating


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CheckifTheNumberisFascinating
{
    public class Solution 
    {
        public static bool IsFascinating(int n) 
        {
            if(n > 333)
            {
                return false;
            }

            int concatenated = n;
            int second = n * 2;
            int third = n * 3;

            HashSet<int> set = new(9);

            while(second > 0)
            {
                concatenated = concatenated * 10 + second % 10;
                second /= 10;

                concatenated = concatenated * 10 + third % 10;
                third /= 10;
            }

            while(concatenated > 0)
            {
                int digit = concatenated % 10;

                if(digit == 0 || !set.Add(digit))
                {
                    return false;
                }

                concatenated /= 10;
            }

            return true;
        }
    }
    
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.IsFascinating(192), true),
                ResultTester.CheckResult<bool>(Solution.IsFascinating(100), false),
            };
            return results;
        }
    }
}