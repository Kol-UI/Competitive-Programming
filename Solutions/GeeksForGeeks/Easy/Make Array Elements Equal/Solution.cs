// Make Array Elements Equal

/*
You are given an integer N. Consider an array arr having N elements where arr[i] = 2*i+1. (The array is 0-indexed)

You are allowed to perform the given operation on the array any number of times:

1) Select two indices i and j and increase arr[i] by 1 and decrease arr[j] by 1.

Your task is to find the minimum number of such operations required to make all the elements of the array equal.

Example 1:

Input:
N = 3
Output:
2
Explanation:
Initially the array is {1, 3, 5}. If we perform
the operation once on the indices 0 and 2, the 
resulting array will be {2, 3, 4}. If we again 
perform the operation once on the indices 0
and 2, the resulting array will be {3, 3, 3}.
Hence, the minimum operations required is 2
in this case. 
Example 2:

Input: 
N = 2
Output:
1
Explanation: 
The array initially is {1, 3}. After performing 
an operation the array will be {2, 2}. Hence,
the answer is 1 in this case.
Your Task:
Complete the function minOperations() which takes the integer N as the input parameter, and returns the minimum operations required to make all the array elements equal.
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.MakeArrayElementsEqual
{
    public class Solution
    {
        public static long MinOperations(int N)
        {
            long result = 0;
            result = N/2;
            result *= (N + 1) /2;
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestMakeArrayElementsEqual()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.MinOperations(12), 36),
                ResultTester.CheckResult<long>(Solution.MinOperations(3), 2),
                ResultTester.CheckResult<long>(Solution.MinOperations(2), 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Make Array Elements Equal");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.EasyGFG, Test.TestMakeArrayElementsEqual());
        }
    }
}