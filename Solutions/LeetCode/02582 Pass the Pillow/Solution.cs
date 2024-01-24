// Pass the Pillow


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.PassthePillow
{
    public class Solution
    {
        public static int PassThePillow(int n, int time)
        {
            int i = 0; 
            while(time >= 0)
            {
                i++;

                if(i == n)
                { 
                    i = n * -1;
                }
                else if(i == -1)
                { 
                    i *= -1; 
                }

                if(time == 0)
                { 
                    return Math.Abs(i); 
                }

                time--;
            }
            return 0; 
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.PassThePillow(4, 5), 2),
                ResultTester.CheckResult<int>(Solution.PassThePillow(3, 2), 3),
            };
            return results;
        }
    }
}