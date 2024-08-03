// Binary Trees With Factors

/*
Given an array of unique integers, arr, where each integer arr[i] is strictly greater than 1.

We make a binary tree using these integers, and each number may be used for any number of times. Each non-leaf node's value should be equal to the product of the values of its children.

Return the number of binary trees we can make. The answer may be too large so return the answer modulo 109 + 7.

 

Example 1:

Input: arr = [2,4]
Output: 3
Explanation: We can make these trees: [2], [4], [4, 2, 2]

Example 2:

Input: arr = [2,4,5,10]
Output: 7
Explanation: We can make these trees: [2], [4], [5], [10], [4, 2, 2], [10, 2, 5], [10, 5, 2].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BinaryTreesWithFactors
{
    public class Solution
    {
        public static int NumFactoredBinaryTrees(int[] arr)
        {
            long counter = 1;
            long mod = 1000000007;
            Array.Sort(arr);
            Dictionary<int,long> records = new Dictionary<int,long>();
            records.Add(arr[0], counter);
            
            for(int i = 1; i < arr.Length; i++)
            {
                counter = 1;
                foreach(int key in records.Keys)
                {
                    if((arr[i]%key == 0) && records.ContainsKey(arr[i]/key))
                    {
                        counter += (records[key] * records[arr[i]/key]);
                    }                
                }  
                records.Add(arr[i],counter);
            }

            long sum  = 0;
            foreach(long curvalue in records.Values)
            {
                sum = (sum + curvalue) % mod;
            }
                
            return (int)sum;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] arr1 = {2,4};
            int[] arr2 = {2,4,5,10};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumFactoredBinaryTrees(arr1), 3),
                ResultTester.CheckResult<int>(Solution.NumFactoredBinaryTrees(arr2), 7),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Binary Trees With Factors");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}