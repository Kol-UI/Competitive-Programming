using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.IPO
{
    // Suppose LeetCode will start its IPO soon. In order to sell a good price of its shares to Venture Capital, LeetCode would like to work on some projects to increase its capital before the IPO.
    // Since it has limited resources, it can only finish at most k distinct projects before the IPO.
    // Help LeetCode design the best way to maximize its total capital after finishing at most k distinct projects.
    // You are given n projects where the ith project has a pure profit profits[i] and a minimum capital of capital[i] is needed to start it.
    // Initially, you have w capital. When you finish a project, you will obtain its pure profit and the profit will be added to your total capital.
    // Pick a list of at most k distinct projects from given projects to maximize your final capital, and return the final maximized capital.
    // The answer is guaranteed to fit in a 32-bit signed integer.

    // Example 1:

    // Input: k = 2, w = 0, profits = [1,2,3], capital = [0,1,1]
    // Output: 4
    // Explanation: Since your initial capital is 0, you can only start the project indexed 0.
    // After finishing it you will obtain profit 1 and your capital becomes 1.
    // With capital 1, you can either start the project indexed 1 or the project indexed 2.
    // Since you can choose at most 2 projects, you need to finish the project indexed 2 to get the maximum capital.
    // Therefore, output the final maximized capital, which is 0 + 1 + 3 = 4.
    
    // Example 2:

    // Input: k = 3, w = 0, profits = [1,2,3], capital = [0,1,2]
    // Output: 6

    public class Solution
    {
        public static int FindMaximizedCapital(int k, int w, int[] profits, int[] capital)
        {
            Dictionary<int,List<int>> projBuckets = new();
            for (int i = 0; i < profits.Length; i++)
            {
                if (!projBuckets.ContainsKey(capital[i]))
                {
                    projBuckets.Add(capital[i], new List<int>());
                }
                projBuckets[capital[i]].Add(profits[i]);
            }
            PriorityQueue<int,int> projectProfit = new();
            int[] projKeys = projBuckets.Keys.ToArray();
            Array.Sort(projKeys);
            int projKeyPtr = 0;

            int completeProj = 0;
            while (completeProj < k)
            {
                while (projKeyPtr < projKeys.Length && w >= projKeys[projKeyPtr])
                {
                    foreach (int proj in projBuckets[projKeys[projKeyPtr]])
                    { 
                        projectProfit.Enqueue(proj, -proj);
                    }
                    projBuckets.Remove(projKeys[projKeyPtr]);
                    projKeyPtr++;
                }
                if (projectProfit.Count > 0)
                { 
                    w += projectProfit.Dequeue();
                    completeProj++;
                }
                else
                { 
                    return w;
                }
            }
            return w;
        }
    }

    public class Test
    {
        public static bool[] TestIPO()
        {
            // Case 1
            int k_502 = 2;
            int w_502 = 0;
            int[] profits_502 = {1, 2, 3};
            int[] capital_502 = {0, 1, 1};
            int result_502 = Solution.FindMaximizedCapital(k_502, w_502, profits_502, capital_502);

            // Case 2
            int k2_502 = 3;
            int w2_502 = 0;
            int[] profits2_502 = {1, 2, 3};
            int[] capital2_502 = {0, 1, 2};
            int result2_502 = Solution.FindMaximizedCapital(k2_502, w2_502, profits2_502, capital2_502);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result_502, 4),
                ResultTester.CheckResult<int>(result2_502, 6)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("IPO");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestIPO());
        }
    }
}