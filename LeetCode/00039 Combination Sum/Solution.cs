// Combination Sum

/*
Given an array of distinct integers candidates and a target integer target, return a list of all unique combinations of candidates where the chosen numbers sum to target. You may return the combinations in any order.

The same number may be chosen from candidates an unlimited number of times. Two combinations are unique if the 
frequency
 of at least one of the chosen numbers is different.

The test cases are generated such that the number of unique combinations that sum up to target is less than 150 combinations for the given input.

 

Example 1:

Input: candidates = [2,3,6,7], target = 7
Output: [[2,2,3],[7]]
Explanation:
2 and 3 are candidates, and 2 + 2 + 3 = 7. Note that 2 can be used multiple times.
7 is a candidate, and 7 = 7.
These are the only two combinations.

Example 2:

Input: candidates = [2,3,5], target = 8
Output: [[2,2,2,2],[2,3,3],[3,5]]

Example 3:

Input: candidates = [2], target = 1
Output: []
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CombinationSum
{
    public class Solution
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target) 
        {
            var result = new List<IList<int>>();
            Search(candidates, target, 0, 0, new List<int>(), result);
            return result;
        }

        private static void Search(int[] candidates, int target, int index, int sum, IList<int> temp, IList<IList<int>> result)
        {
            if (sum == target)
            {
                result.Add(temp.ToArray());
                return;
            }

            while (sum < target && index < candidates.Length)
            {
                temp.Add(candidates[index]);

                Search(candidates, target, index, sum + candidates[index], temp, result);

                temp.RemoveAt(temp.Count - 1);
                index++;
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] candidates1 = {2,3,6,7};
            int target1 = 7;
            int[] candidates2 = {2,3,5};
            int target2 = 8;
            int[] candidates3 = {2};
            int target3 = 1;
            IList<IList<int>> expected1 = new List<IList<int>>
            {
                new List<int> { 2, 2, 3 },
                new List<int> { 7 }
            };
            IList<IList<int>> expected2 = new List<IList<int>>
            {
                new List<int> { 2, 2, 2, 2 },
                new List<int> { 2, 3, 3 },
                new List<int> { 3, 5 }
            };
            IList<IList<int>> expected3 = new List<IList<int>>
            {
                new List<int> { }
            };
            IList<IList<int>> result1 = Solution.CombinationSum(candidates1, target1);
            IList<IList<int>> result2 = Solution.CombinationSum(candidates2, target2);
            IList<IList<int>> result3 = Solution.CombinationSum(candidates3, target3);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(result1, expected1),
                ResultTester.CheckResult<IList<IList<int>>>(result2, expected2),
                ResultTester.CheckResult<IList<IList<int>>>(result3, expected3)
            };
            return results;
        }
    }
}