// Mini-Max Sum

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.MiniMaxSum
{
    public class Solution
    {
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();

            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                minSum += arr[i];
            }

            for (int i = 1; i < arr.Count; i++)
            {
                maxSum += arr[i];
            }

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Mini-Max Sum");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerRank, ProblemCategory.EasyHR);
        }
    }
}