// Combinations

/*
Given two integers n and k, return all possible combinations of k numbers chosen from the range [1, n].

You may return the answer in any order.

 

Example 1:

Input: n = 4, k = 2
Output: [[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]
Explanation: There are 4 choose 2 = 6 total combinations.
Note that combinations are unordered, i.e., [1,2] and [2,1] are considered to be the same combination.

Example 2:

Input: n = 1, k = 1
Output: [[1]]
Explanation: There is 1 choose 1 = 1 total combination.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.Combinations
{
    public class Solution
    {
        // BackTracking
        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> result = new List<IList<int>>();
            BackTrack(result, new List<int>(), n, k, 1);
            return result;
        }

        void BackTrack(IList<IList<int>> result, IList<int> tempList, int n, int k, int start)
        {
            if(tempList.Count == k)
            {
                int[] array = new int[k];
                tempList.CopyTo(array, 0);
                result.Add(array.ToList());
                return;
            }
            for(int i= start; i<=n; i++)
            {
                tempList.Add(i);
                BackTrack(result, tempList, n, k, i+1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
        
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Combinations");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}