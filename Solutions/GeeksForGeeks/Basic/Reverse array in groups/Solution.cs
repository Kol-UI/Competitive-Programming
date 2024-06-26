// Reverse array in groups

/*
Given an array arr[] of positive integers of size N. Reverse every sub-array group of size K.

Note: If at any instance, there are no more subarrays of size greater than or equal to K, then reverse the last subarray (irrespective of its size). You shouldn't return any array, modify the given array in-place.

Example 1:

Input:
N = 5, K = 3
arr[] = {1,2,3,4,5}
Output: 3 2 1 5 4
Explanation: First group consists of elements
1, 2, 3. Second group consists of 4,5.
 

Example 2:

Input:
N = 4, K = 3
arr[] = {5,6,8,9}
Output: 8 6 5 9
 

Your Task:
You don't need to read input or print anything. The task is to complete the function reverseInGroups() which takes the array, N and K as input parameters and modifies the array in-place. 
*/

using System;
using System.Linq;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Basic.Reversearrayingroups
{
    public class Solution 
    {
        public void ReverseInGroups(int[] A, int N, int K)
        {
            for (int i = 0; i < N; i += K)
            {
                int left = i;
                int right = Math.Min(i + K - 1, N - 1);
        
                // Reverse the subarray within the group
                while (left < right)
                {
                    int temp = A[left];
                    A[left] = A[right];
                    A[right] = temp;
                    left++;
                    right--;
                }
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse array in groups");
            ResultTester.SpecialTestCase(ProblemOrigin.GeeksForGeeks, ProblemCategory.BasicGFG);
        }
    }
}