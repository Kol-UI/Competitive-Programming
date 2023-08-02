// H-Index II

/*
Given an array of integers citations where citations[i] is the number of citations a researcher received for their ith paper and citations is sorted in ascending order, return the researcher's h-index.

According to the definition of h-index on Wikipedia: The h-index is defined as the maximum value of h such that the given researcher has published at least h papers that have each been cited at least h times.

You must write an algorithm that runs in logarithmic time.

 

Example 1:

Input: citations = [0,1,3,5,6]
Output: 3
Explanation: [0,1,3,5,6] means the researcher has 5 papers in total and each of them had received 0, 1, 3, 5, 6 citations respectively.
Since the researcher has 3 papers with at least 3 citations each and the remaining two with no more than 3 citations each, their h-index is 3.

Example 2:

Input: citations = [1,2,100]
Output: 2
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.HIndexII
{
    public class Solution
    {
        internal static int HIndex(int[] citations)
        {
            int value1 = 0;
            int n = citations.Length;
            int value2 = n - 1;

            while(value1 <= value2)
            {
                int mid = (value1 + value2) / 2;
                if(citations[mid] == (n-mid))
                {
                    return n - mid;
                }
                else
                {
                    if(citations[mid] > (n - mid))
                    {
                        value2 = mid - 1;
                    }
                    else
                    {
                        value1 = mid + 1;
                    }
                }
            }
            return n - value1;
        }
    }

    public class Test
    {
        public static bool[] TestHIndexII()
        {
            int[] citations1 = {0,1,3,5,6};
            int[] citations2 = {1,2,100};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.HIndex(citations1), 3),
                ResultTester.CheckResult<int>(Solution.HIndex(citations2), 2)
            };
            return results;
        }
    }
}