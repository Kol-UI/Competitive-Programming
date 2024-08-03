// Most Profit Assigning Work

/*
You have n jobs and m workers. You are given three arrays: difficulty, profit, and worker where:

difficulty[i] and profit[i] are the difficulty and the profit of the ith job, and
worker[j] is the ability of jth worker (i.e., the jth worker can only complete a job with difficulty at most worker[j]).
Every worker can be assigned at most one job, but one job can be completed multiple times.

For example, if three workers attempt the same job that pays $1, then the total profit will be $3. If a worker cannot complete any job, their profit is $0.
Return the maximum profit we can achieve after assigning the workers to the jobs.

 

Example 1:

Input: difficulty = [2,4,6,8,10], profit = [10,20,30,40,50], worker = [4,5,6,7]
Output: 100
Explanation: Workers are assigned jobs of difficulty [4,4,6,6] and they get a profit of [20,20,30,30] separately.

Example 2:

Input: difficulty = [85,47,57], profit = [24,66,99], worker = [40,25,25]
Output: 0
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MostProfitAssigningWork
{
    public class Solution 
    {
        public static int MaxProfitAssignment(int[] difficulty, int[] profits, int[] worker) 
        {
            (int p, int d)[] pd = new (int, int)[difficulty.Length];
            
            for(int i = 0; i < difficulty.Length; i++)            
                pd[i] = (profits[i], difficulty[i]);
            
            Array.Sort(pd, (x, y) => y.p - x.p);                    
            Array.Sort(worker, (x, y) => y - x);
            
            int currentWorker = 0;
            int maxProfit = 0;
            
            for(int i = 0; i < pd.Length; i++)
            {
                while (currentWorker < worker.Length && worker[currentWorker] >= pd[i].d) 
                {
                    maxProfit += pd[i].p;
                    currentWorker++;
                }
            }
                    
            return maxProfit;
        }  
    }

    public class Test
    {
        public static bool[] TestMostProfitAssigningWork()
        {
            int[] difficulty1 = {2,4,6,8,10};
            int[] profit1 = {10,20,30,40,50};
            int[] worker1 = {4,5,6,7};

            int[] difficulty2 = {85,47,57};
            int[] profit2 = {24,66,99};
            int[] worker2 = {40,25,25};

            int result1 = Solution.MaxProfitAssignment(difficulty1, profit1, worker1);
            int result2 = Solution.MaxProfitAssignment(difficulty2, profit2, worker2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 100),
                ResultTester.CheckResult<int>(result2, 0)
            };

            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Profit Assigning Work");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestMostProfitAssigningWork());
        }
    }
}