// Print first n Fibonacci Numbers

/*
Given a number N, find the first N Fibonacci numbers. The first two number of the series are 1 and 1.

Example 1:

Input:
N = 5
Output: 1 1 2 3 5


Example 2:

Input:
N = 7
Output: 1 1 2 3 5 8 13

Your Task:
Your task is to complete printFibb() which takes single argument N and returns a list of first N Fibonacci numbers.
*/

using System;
using System.Linq;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Basic.PrintfirstnFibonacciNumbers
{
    public class Solution
    {
        public static long[] PrintFibb(int n)
        {
            long[] result = new long[n];
        
            long a = 1;
            long b = 1;
            result[0] = a;
            if (n > 1) result[1] = b;
    
            for (int i = 2; i < n; i++)
            {
                long c = a + b;
                result[i] = c;
                a = b;
                b = c;
            }
    
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            long[] result1 = {1,1,2,3,5};
            long[] result2 = {1,1,2,3,5,8,13};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long[]>(Solution.PrintFibb(5), result1),
                ResultTester.CheckResult<long[]>(Solution.PrintFibb(7), result2),
            };
            return results;
        }
    }
}