// Equilibrium Point

/*
Given an array A of n positive numbers. The task is to find the first equilibrium point in an array. Equilibrium point in an array is a position such that the sum of elements before it is equal to the sum of elements after it.

Note: Return equilibrium point in 1-based indexing. Return -1 if no such point exists. 

Example 1:

Input: 
n = 5 
A[] = {1,3,5,2,2} 
Output: 
3 
Explanation:  
equilibrium point is at position 3 as sum of elements before it (1+3) = sum of elements after it (2+2). 

Example 2:

Input:
n = 1
A[] = {1}
Output: 
1
Explanation:
Since there's only element hence its only the equilibrium point.
Your Task:
The task is to complete the function equilibriumPoint() which takes the array and n as input parameters and returns the point of equilibrium. 
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.EquilibriumPoint
{
    public class Solution
    {
        public static int equilibriumPoint(int[] arr, int N)
        {
            if (N == 1)
            {
                return 1;
            }
        
            int totalSum = 0;
            for (int i = 0; i < N; i++)
            {
                totalSum += arr[i];
            }
        
            int leftSum = 0;
            for (int i = 0; i < N; i++)
            {
                totalSum -= arr[i];
                
                if (leftSum == totalSum)
                {
                    return i + 1;
                }
        
                leftSum += arr[i];
            }
        
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 5;
            int[] A1 = {1,3,5,2,2};
            int n2 = 1;
            int[] A2 = {1};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.equilibriumPoint(A1, n1), 3),
                ResultTester.CheckResult<int>(Solution.equilibriumPoint(A2, n2), 1),
            };
            return results;
        }
    }
}