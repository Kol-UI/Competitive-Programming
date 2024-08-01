// Counting Bits

/*
Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

 

Example 1:

Input: n = 2
Output: [0,1,1]
Explanation:
0 --> 0
1 --> 1
2 --> 10

Example 2:

Input: n = 5
Output: [0,1,1,2,1,2]
Explanation:
0 --> 0
1 --> 1
2 --> 10
3 --> 11
4 --> 100
5 --> 101
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CountingBits
{
    public class Solution
    {
        public static int[] CountBits(int n)
        {
            var result = new int[n + 1];
            var kvp = new Dictionary<int, int>();
            
            for (int i = 0; i <= n; i++)
            {
                var numberOfOnes = 0;
                var temp = i;
                while (temp != 0)
                {
                    var rem = temp % 2;
                    temp /= 2;
                    if (rem == 1)
                    {
                        numberOfOnes++;
                    }
                    if (kvp.ContainsKey(temp))
                    {
                        var value = kvp[temp];
                        numberOfOnes += value;
                        break;
                    }
                }
                kvp.Add(i, numberOfOnes);
                result[i] = numberOfOnes;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCountingBits()
        {
            int[] result1 = Solution.CountBits(2);
            int[] result2 = Solution.CountBits(5);
            int[] expected1 = {0,1,1};
            int[] expected2 = {0,1,1,2,1,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Counting Bits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCountingBits());
        }
    }
}