// Find K Closest Elements

/*
Given a sorted integer array arr, two integers k and x, return the k closest integers to x in the array. The result should also be sorted in ascending order.

An integer a is closer to x than an integer b if:

|a - x| < |b - x|, or
|a - x| == |b - x| and a < b
 

Example 1:

Input: arr = [1,2,3,4,5], k = 4, x = 3
Output: [1,2,3,4]

Example 2:

Input: arr = [1,2,3,4,5], k = 4, x = -1
Output: [1,2,3,4]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindKClosestElements
{
    public class Solution 
    {
        public static IList<int> FindClosestElements(int[] arr, int k, int x) 
        {
            int start = 0, end = arr.Length - 1;

            while (end - start >= k)
            {
                if (Math.Abs(x - arr[end]) < Math.Abs(x - arr[start]))
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }
            
            int[] ret = new int[k];
            Array.Copy(arr, start, ret, 0, k);
                
            return ret.ToList();
        }
    }

    public class Test
    {
        public static bool[] TestFindKClosestElements()
        {
            int[] arr = {1,2,3,4,5};
            int k = 4;
            int x1 = 3;
            int x2 = -1;
            IList<int> result1 = LeetCode.FindKClosestElements.Solution.FindClosestElements(arr, k, x1);
            IList<int> result2 = LeetCode.FindKClosestElements.Solution.FindClosestElements(arr, k, x2);
            int[] expected = {1,2,3,4};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(result1, expected),
                ResultTester.CheckResult<IList<int>>(result2, expected)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find K Cloest Elements");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestFindKClosestElements());
        }
    }
}