// Minimum Amount of Time to Fill Cups


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumAmountofTimetoFillCups
{
    public class Solution 
    {
        public static int FillCups(int[] amount) 
        {
            var q = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

            q.Enqueue(amount[0], amount[0]);
            q.Enqueue(amount[1], amount[1]);
            q.Enqueue(amount[2], amount[2]);        

            var t = 0;

            while(q.Peek() != 0)
            {
                var max1 = q.Dequeue();
                var max2 = q.Dequeue();

                if(max1 != 0)
                {
                    max1--;
                }

                q.Enqueue(max1, max1);

                if(max2 != 0)
                {
                    max2--;
                }

                q.Enqueue(max2, max2);
                t++;
            }

            return t;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FillCups(new int[]{1,4,2}), 4),
                ResultTester.CheckResult<int>(Solution.FillCups(new int[]{5,4,4}), 7),
                ResultTester.CheckResult<int>(Solution.FillCups(new int[]{5,0,0}), 5),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Amount of Time to Fill Cups");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}