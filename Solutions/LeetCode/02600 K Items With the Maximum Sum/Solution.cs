using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KItemsWiththeMaximumSum
{
    /*
        There is a bag that consists of items, each item has a number 1, 0, or -1 written on it.

        You are given four non-negative integers numOnes, numZeros, numNegOnes, and k.

        The bag initially contains:

        numOnes items with 1s written on them.
        numZeroes items with 0s written on them.
        numNegOnes items with -1s written on them.
        We want to pick exactly k items among the available items. Return the maximum possible sum of numbers written on the items.

        

        Example 1:

        Input: numOnes = 3, numZeros = 2, numNegOnes = 0, k = 2
        Output: 2
        Explanation: We have a bag of items with numbers written on them {1, 1, 1, 0, 0}. We take 2 items with 1 written on them and get a sum in a total of 2.
        It can be proven that 2 is the maximum possible sum.
        
        Example 2:

        Input: numOnes = 3, numZeros = 2, numNegOnes = 0, k = 4
        Output: 3
        Explanation: We have a bag of items with numbers written on them {1, 1, 1, 0, 0}. We take 3 items with 1 written on them, and 1 item with 0 written on it, and get a sum in a total of 3.
        It can be proven that 3 is the maximum possible sum.
    */
    public class Solution
    {
        // Greedy Way
        public static int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
        {
            if (k < 0 || k > numOnes + numZeros + numNegOnes)
            {
                return -1;
            }

            int result = Math.Min(k, numOnes);

            if ((k -= Math.Min(k, numOnes)) > 0) 
            {
                k -= Math.Min(k, numZeros);
            }       

            return result - k;   
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int numOnes2600Case1 = 3;
            int numZeros2600Case1 = 2;
            int numNegOnes2600Case1 = 0;
            int k2600Case1 = 2;
            int result2600Case1 = Solution.KItemsWithMaximumSum(numOnes2600Case1, numZeros2600Case1, numNegOnes2600Case1, k2600Case1);

            // Case 2
            int numOnes2600Case2 = 3;
            int numZeros2600Case2 = 2;
            int numNegOnes2600Case2 = 0;
            int k2600Case2 = 4;
            int result2600Case2 = Solution.KItemsWithMaximumSum(numOnes2600Case2, numZeros2600Case2, numNegOnes2600Case2, k2600Case2);

            int output1 = 2;
            int output2 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result2600Case1, output1),
                ResultTester.CheckResult<int>(result2600Case2, output2)
            };
            return results;
        }
    }
}

