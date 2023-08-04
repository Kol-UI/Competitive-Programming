// Equal Row and Column Pairs

/*
Given a 0-indexed n x n integer matrix grid, return the number of pairs (ri, cj) such that row ri and column cj are equal.
A row and column pair is considered equal if they contain the same elements in the same order (i.e., an equal array).


Example 1:

Input: grid = [[3,2,1],[1,7,6],[2,7,7]]
Output: 1
Explanation: There is 1 equal row and column pair:
- (Row 2, Column 1): [2,7,7]

Example 2:

Input: grid = [[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]
Output: 3
Explanation: There are 3 equal row and column pairs:
- (Row 0, Column 0): [3,1,2,2]
- (Row 2, Column 2): [2,4,2,2]
- (Row 3, Column 2): [2,4,2,2]
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EqualRowandColumnPairs
{
    public class Solution
    {
        const int BASE = 5119;
        const int MOD = 1000000007;

        public static int EqualPairs(int[][] grid)
        {
            int n = grid.Length;
            long[] row_hash = new long[n];

            int res = 0;

            // rows
            for (int i = 0; i < n; i++)
            {
                long h = 0;
                for (int j = 0; j < n; j++) h = (h * BASE + grid[i][j]) % MOD;
                row_hash[i] = h;
            }

            // cols
            for (int j = 0; j < n; j++)
            {
                long h = 0;
                for (int i = 0; i < n; i++) h = (h * BASE + grid[i][j]) % MOD;

                for (int i = 0; i < n; i++) res += row_hash[i] == h ? 1 : 0;
            }

            return res;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[][] case1 = new int[][]
            {
                new int[] { 3, 2, 1 },
                new int[] { 1, 7, 6 },
                new int[] { 2, 7, 7 }
            };

            int[][] case2 = new int[][]
            {
                new int[] { 3,1,2,2 },
                new int[] { 1,4,4,5 },
                new int[] { 2,4,2,2 },
                new int[] { 2,4,2,2 }
            };

            int result1 = Solution.EqualPairs(case1);
            int result2 = Solution.EqualPairs(case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 3)
            };
            return results;
        }
    }
}
