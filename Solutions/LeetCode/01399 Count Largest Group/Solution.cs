// Count Largest Group


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountLargestGroup
{
    public class Solution
    {
        public static int CountLargestGroup(int n)
        {
            Dictionary<int,int> list = new Dictionary<int,int>();
            int maxCount = 0;
            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int k = i;
                while (k > 0)
                {
                    sum += k % 10;
                    k /= 10;                
                }
                if (list.ContainsKey(sum))
                    list[sum]++;
                else
                    list[sum] = 1;
                maxCount = Math.Max(maxCount, list[sum]);
            }
            return list.Where(e => e.Value == maxCount).Count();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountLargestGroup(13), 4),
                ResultTester.CheckResult<int>(Solution.CountLargestGroup(2), 2),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1399");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}