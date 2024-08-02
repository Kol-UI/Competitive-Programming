// Total Cost to Hire K Workers

/*
ou are given a 0-indexed integer array costs where costs[i] is the cost of hiring the ith worker.

You are also given two integers k and candidates. We want to hire exactly k workers according to the following rules:

You will run k sessions and hire exactly one worker in each session.
In each hiring session, choose the worker with the lowest cost from either the first candidates workers or the last candidates workers. Break the tie by the smallest index.
For example, if costs = [3,2,7,7,1,2] and candidates = 2, then in the first hiring session, we will choose the 4th worker because they have the lowest cost [3,2,7,7,1,2].
In the second hiring session, we will choose 1st worker because they have the same lowest cost as 4th worker but they have the smallest index [3,2,7,7,2]. Please note that the indexing may be changed in the process.
If there are fewer than candidates workers remaining, choose the worker with the lowest cost among them. Break the tie by the smallest index.
A worker can only be chosen once.
Return the total cost to hire exactly k workers.

 

Example 1:

Input: costs = [17,12,10,2,7,2,11,20,8], k = 3, candidates = 4
Output: 11
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [17,12,10,2,7,2,11,20,8]. The lowest cost is 2, and we break the tie by the smallest index, which is 3. The total cost = 0 + 2 = 2.
- In the second hiring round we choose the worker from [17,12,10,7,2,11,20,8]. The lowest cost is 2 (index 4). The total cost = 2 + 2 = 4.
- In the third hiring round we choose the worker from [17,12,10,7,11,20,8]. The lowest cost is 7 (index 3). The total cost = 4 + 7 = 11. Notice that the worker with index 3 was common in the first and last four workers.
The total hiring cost is 11.

Example 2:

Input: costs = [1,2,4,1], k = 3, candidates = 3
Output: 4
Explanation: We hire 3 workers in total. The total cost is initially 0.
- In the first hiring round we choose the worker from [1,2,4,1]. The lowest cost is 1, and we break the tie by the smallest index, which is 0. The total cost = 0 + 1 = 1. Notice that workers with index 1 and 2 are common in the first and last 3 workers.
- In the second hiring round we choose the worker from [2,4,1]. The lowest cost is 1 (index 2). The total cost = 1 + 1 = 2.
- In the third hiring round there are less than three candidates. We choose the worker from the remaining workers [2,4]. The lowest cost is 2 (index 0). The total cost = 2 + 2 = 4.
The total hiring cost is 4.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TotalCosttoHireKWorkers
{
    public class Solution
    {
        public static long TotalCost(int[] costs, int k, int candidates) 
        {
            var workers = new PriorityQueue<(int cost, bool isFirstCandidate), (int cost, int index)>();

            var first = 0;
            var last = costs.Length - 1;
            long totalHireCost = 0;

            var firstCandidates = candidates;
            var lastCandidates = candidates;

            for (var session = 0; session < k; session++)
            {
                var possibleHires = candidates;

                while (first <= last && firstCandidates > 0)
                {
                    workers.Enqueue((costs[first], true), (costs[first], first));

                    first++;
                    firstCandidates--;
                }

                while (first <= last && lastCandidates > 0)
                {
                    workers.Enqueue((costs[last], false), (costs[last], last));

                    last--;
                    lastCandidates--;
                }

                if (workers.Count > 0)
                {
                    var lowestCostWorker = workers.Dequeue();
                    totalHireCost += lowestCostWorker.cost;

                    if (lowestCostWorker.isFirstCandidate) firstCandidates++;
                    else lastCandidates++;
                }
            }

            return totalHireCost;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] costs1 = {17,12,10,2,7,2,11,20,8};
            int k1 = 3;
            int candidates1 = 4;

            int[] costs2 = {1,2,4,1};
            int k2 = 3;
            int candidates2 = 3;

            long result1 = Solution.TotalCost(costs1, k1, candidates1);
            long result2 = Solution.TotalCost(costs2, k2, candidates2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(result1, 11),
                ResultTester.CheckResult<long>(result2, 4)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Total Cost to Hire K Workers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}