// Knight Dialer

/*
The chess knight has a unique movement, it may move two squares vertically and one square horizontally, or two squares horizontally and one square vertically (with both forming the shape of an L). The possible movements of chess knight are shown in this diagaram:

A chess knight can move as indicated in the chess diagram below:


We have a chess knight and a phone pad as shown below, the knight can only stand on a numeric cell (i.e. blue cell).


Given an integer n, return how many distinct phone numbers of length n we can dial.

You are allowed to place the knight on any numeric cell initially and then you should perform n - 1 jumps to dial a number of length n. All jumps should be valid knight jumps.

As the answer may be very large, return the answer modulo 109 + 7.

 

Example 1:

Input: n = 1
Output: 10
Explanation: We need to dial a number of length 1, so placing the knight over any numeric cell of the 10 cells is sufficient.

Example 2:

Input: n = 2
Output: 20
Explanation: All the valid number we can dial are [04, 06, 16, 18, 27, 29, 34, 38, 40, 43, 49, 60, 61, 67, 72, 76, 81, 83, 92, 94]

Example 3:

Input: n = 3131
Output: 136006598
Explanation: Please take care of the mod.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.KnightDialer
{
    public class Solution
    {
        public static int KnightDialer(int n)
        {
            int MOD = 1000000007;
            
            int[][] moves = new int[][]
            {
                new int[]{4, 6},
                new int[]{6, 8},
                new int[]{7, 9},
                new int[]{4, 8},
                new int[]{3, 9, 0},
                new int[]{},
                new int[]{1, 7, 0},
                new int[]{2, 6},
                new int[]{1, 3},
                new int[]{2, 4}
            };
            
            Dictionary<(int, int), int> memo = new Dictionary<(int, int), int>();
            
            int totalCount = 0;
            
            for (int i = 0; i < 10; i++)
            {
                totalCount = (totalCount + CountingTotal(n - 1, i, moves, memo, MOD)) % MOD;
            }
            
            return totalCount;
        }

        private static int CountingTotal(int remainingMoves, int currentNum, int[][] moves, Dictionary<(int, int), int> memo, int MOD)
        {
            if (remainingMoves == 0) 
            {
                return 1;
            }
            
            if (memo.ContainsKey((remainingMoves, currentNum)))
            {
                return memo[(remainingMoves, currentNum)];
            }
            
            int totalCount = 0;
            
            foreach (int nextNum in moves[currentNum])
            {
                totalCount = (totalCount + CountingTotal(remainingMoves - 1, nextNum, moves, memo, MOD)) % MOD;
            }
            
            memo[(remainingMoves, currentNum)] = totalCount;

            return totalCount;
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.KnightDialer(1), 10),
                ResultTester.CheckResult<int>(Solution.KnightDialer(2), 20),
                ResultTester.CheckResult<int>(Solution.KnightDialer(3131), 136006598),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Knight Dialer");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}