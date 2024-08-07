// Count Vowels Permutation

/*
Given an integer n, your task is to count how many strings of length n can be formed under the following rules:

Each character is a lower case vowel ('a', 'e', 'i', 'o', 'u')
Each vowel 'a' may only be followed by an 'e'.
Each vowel 'e' may only be followed by an 'a' or an 'i'.
Each vowel 'i' may not be followed by another 'i'.
Each vowel 'o' may only be followed by an 'i' or a 'u'.
Each vowel 'u' may only be followed by an 'a'.
Since the answer may be too large, return it modulo 10^9 + 7.

 

Example 1:

Input: n = 1
Output: 5
Explanation: All possible strings are: "a", "e", "i" , "o" and "u".

Example 2:

Input: n = 2
Output: 10
Explanation: All possible strings are: "ae", "ea", "ei", "ia", "ie", "io", "iu", "oi", "ou" and "ua".

Example 3: 

Input: n = 5
Output: 68
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountVowelsPermutation
{
    public class Solution
    {
        public static int CountVowelPermutation(int n)
        {
            const int MOD = 1000000007;
            
            long a = 1;
            long e = 1;
            long i = 1;
            long o = 1;
            long u = 1;
            
            for (int j = 1; j < n; j++)
            {
                long a_next = e;
                long e_next = (a + i) % MOD;
                long i_next = (a + e + o + u) % MOD;
                long o_next = (i + u) % MOD;
                long u_next = a;
                
                a = a_next;
                e = e_next;
                i = i_next;
                o = o_next;
                u = u_next;
            }
            
            return (int)((a + e + i + o + u) % MOD);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountVowelPermutation(1), 5),
                ResultTester.CheckResult<int>(Solution.CountVowelPermutation(2), 10),
                ResultTester.CheckResult<int>(Solution.CountVowelPermutation(5), 68),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Count Vowels Permutation");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}