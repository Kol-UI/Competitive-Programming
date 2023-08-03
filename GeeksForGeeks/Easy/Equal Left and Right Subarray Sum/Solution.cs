// Equal Left and Right Subarray Sum

/*
    Given an array A of n positive numbers. The task is to find the first index in the array such that the sum of elements before it is equal to the sum of elements after it.

    Note:  Array is 1-based indexed.

    Example 1:
    Input: 
    n = 5 
    A[] = {1,3,5,2,2} 
    Output: 3 
    Explanation: For second test case 
    at position 3 elements before it 
    (1+3) = elements after it (2+2). 
    

    Example 2:
    Input:
    n = 1
    A[] = {1}
    Output: 1
    Explanation:
    Since its the only element hence
    it is the only point.
    
    Your Task:
    The task is to complete the function equalSum() which takes the array and n as input parameters and returns the point. Return -1 if no such point exists.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.EqualLeftandRightSubarraySum
{
    public class Solution
    {
        public static int EqualSum(int [] A, int N)
        {
            int sum = 0;
            for(int i = 0; i < N; i++)
            {
                sum += A[i];
            }
            int lsum = 0;
            for(int i = 0; i < N; i++)
            {
                sum -= A[i];
                if(sum == lsum)
                {
                    return i + 1;
                }
                
                else
                {
                    lsum += A[i];
                }
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestEqualLeftandRightSubarraySum()
        {
            // Case 1
            int[] ACase1 = {1,3,5,2,2};
            int n1 = 5;
            int Output1 = GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Solution.EqualSum(ACase1 , n1);

            // Case2
            int[] ACase2 = {1};
            int n2 = 1;
            int Output2 = GeeksForGeeks.Easy.EqualLeftandRightSubarraySum.Solution.EqualSum(ACase1 , n2);
            
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Output1, 3),
                ResultTester.CheckResult<int>(Output2, 1)
            };
            return results;
        }
    }
}
