// Pass the Pillow


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
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

    public class Solution2
    {
        public int PassThePillow(int n, int time)
        {
            int position = 1;
            int direction = 1;

            while (time > 0)
            {
                position += direction;

                if (position == n || position == 1)
                {
                    direction *= -1;
                }

                time--;
            }

            return position;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution2 solution2 = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.PassThePillow(4, 5), 2),
                ResultTester.CheckResult<int>(Solution.PassThePillow(3, 2), 3),
                ResultTester.CheckResult<int>(solution2.PassThePillow(4, 5), 2),
                ResultTester.CheckResult<int>(solution2.PassThePillow(3, 2), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Pass the Pillow");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}