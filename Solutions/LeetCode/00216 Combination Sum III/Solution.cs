// Combination Sum III

/*
Find all valid combinations of k numbers that sum up to n such that the following conditions are true:

Only numbers 1 through 9 are used.
Each number is used at most once.
Return a list of all possible valid combinations. The list must not contain the same combination twice, and the combinations may be returned in any order.

 

Example 1:

Input: k = 3, n = 7
Output: [[1,2,4]]
Explanation:
1 + 2 + 4 = 7
There are no other valid combinations.

Example 2:

Input: k = 3, n = 9
Output: [[1,2,6],[1,3,5],[2,3,4]]
Explanation:
1 + 2 + 6 = 9
1 + 3 + 5 = 9
2 + 3 + 4 = 9
There are no other valid combinations.

Example 3:

Input: k = 4, n = 1
Output: []
Explanation: There are no valid combinations.
Using 4 different numbers in the range [1,9], the smallest sum we can get is 1+2+3+4 = 10 and since 10 > 1, there are no valid combination.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CombinationSumIII
{
    public class Solution
    {
        // Backtracking
        public IList<IList<int>> CombinationSum3(int k, int n)
        {
            List<IList<int>> results = new();
            Stack<int> stack = new();
            FindSum(1, k, n);
            return results;

            void FindSum(int startingValue, int numberOfNumbers, int targetSum)
            {
                if (targetSum is 0 && numberOfNumbers is 0) results.Add(stack.ToArray());
                if (targetSum is 0 || numberOfNumbers is 0) return;

                for (int value = startingValue; value < 10; value++)
                {
                    stack.Push(value);
                    FindSum(value + 1, numberOfNumbers - 1, targetSum - value);
                    stack.Pop();
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combination Sum III");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}