// Combination Sum II


/*
Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sum to target.

Each number in candidates may only be used once in the combination.

Note: The solution set must not contain duplicate combinations.

 

Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8
Output: 
[
[1,1,6],
[1,2,5],
[1,7],
[2,6]
]


Example 2:

Input: candidates = [2,5,2,1,2], target = 5
Output: 
[
[1,2,2],
[5]
]
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CombinationSumII
{
    public class Solution
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> answer = new List<IList<int>>();
            int total = 0; 
            int i = 0;
            List<int> current = new List<int>();
            Array.Sort(candidates);
            Backtracking(answer, current, i, total, target, candidates);
            return answer;
        }

        public static void Backtracking(IList<IList<int>> answer, List<int> current, int i, int total, int target, int[] candidates)
        {
            if (total == target)
            {
                answer.Add(new List<int>(current));
                return;
            }
            if (total > target)
            {
                return;
            }
            if (i == candidates.Length)
            {
                return;
            }
            current.Add(candidates[i]);
            total = total + candidates[i];
            Backtracking(answer, current, i+1, total, target,candidates);
            current.RemoveAt(current.Count-1);
            total = total - candidates[i];
            while((i+1) < candidates.Length && candidates[i] == candidates[i+1])
            {
                i = i + 1; 
            }
            Backtracking(answer, current, i+1, total, target, candidates);
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            int[] candidates1 = {10,1,2,7,6,1,5};
            int target1 = 8;
            int[] candidates2 = {2,5,2,1,2};
            int target2 = 5;
            IList<IList<int>> result1 = new List<IList<int>>
            {
                new List<int> { 1, 1, 6 },
                new List<int> { 1, 2, 5 },
                new List<int> { 1, 7 },
                new List<int> { 2, 6 }
            };
            IList<IList<int>> result2 = new List<IList<int>>
            {
                new List<int> { 1, 2, 2 },
                new List<int> { 5 }
            };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(Solution.CombinationSum2(candidates1, target1), result1),
                ResultTester.CheckResult<IList<IList<int>>>(Solution.CombinationSum2(candidates2, target2), result2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum II");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}