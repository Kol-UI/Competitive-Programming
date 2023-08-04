// The K Weakest Rows in a Matrix

/*
You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.

A row i is weaker than a row j if one of the following is true:

The number of soldiers in row i is less than the number of soldiers in row j.
Both rows have the same number of soldiers and i < j.
Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.

 

Example 1:

Input: mat = 
[[1,1,0,0,0],
 [1,1,1,1,0],
 [1,0,0,0,0],
 [1,1,0,0,0],
 [1,1,1,1,1]], 
k = 3
Output: [2,0,3]
Explanation: 
The number of soldiers in each row is: 
- Row 0: 2 
- Row 1: 4 
- Row 2: 1 
- Row 3: 2 
- Row 4: 5 
The rows ordered from weakest to strongest are [2,0,3,1,4].

Example 2:

Input: mat = 
[[1,0,0,0],
 [1,1,1,1],
 [1,0,0,0],
 [1,0,0,0]], 
k = 2
Output: [0,2]
Explanation: 
The number of soldiers in each row is: 
- Row 0: 1 
- Row 1: 4 
- Row 2: 1 
- Row 3: 1 
The rows ordered from weakest to strongest are [0,2,3,1].
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TheKWeakestRowsinaMatrix
{
    public class Solution 
    {
        public static int[] KWeakestRows(int[][] mat, int k) 
        {
            return mat.Select((r, i) => (Index: i, Sum: r.Sum()))
                .OrderBy(a => a.Sum)
                .Take(k)
                .Select(a => a.Index)
                .ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestTheKWeakestRowsinaMatrix()
        {
            int[][] mat1 = new int[][]
            {
                new int[] { 1,1,0,0,0 },
                new int[] { 1,1,1,1,0 },
                new int[] { 1,1,0,0,0 },
                new int[] { 1,0,0,0,0 },
                new int[] { 1,1,0,0,0 },
                new int[] { 1,1,1,1,1 }
            };
            int k1 = 3;

            int[][] mat2 = new int[][]
            {
                new int[] { 1,0,0,0 },
                new int[] { 1,1,1,1 },
                new int[] { 1,0,0,0 },
                new int[] { 1,0,0,0 },
            };
            int k2 = 2;

            int[] result1 = Solution.KWeakestRows(mat1, k1);
            int[] result2 = Solution.KWeakestRows(mat2, k2);

            int[] expected1 = {3,0,2};
            int[] expected2 = {0,2};
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2)
            };
            return results;
        }
    }
}
