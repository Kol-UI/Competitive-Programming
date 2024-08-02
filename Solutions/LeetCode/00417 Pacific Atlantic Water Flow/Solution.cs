// Pacific Atlantic Water Flow

/*
There is an m x n rectangular island that borders both the Pacific Ocean and Atlantic Ocean. The Pacific Ocean touches the island's left and top edges, and the Atlantic Ocean touches the island's right and bottom edges.

The island is partitioned into a grid of square cells. You are given an m x n integer matrix heights where heights[r][c] represents the height above sea level of the cell at coordinate (r, c).

The island receives a lot of rain, and the rain water can flow to neighboring cells directly north, south, east, and west if the neighboring cell's height is less than or equal to the current cell's height. Water can flow from any cell adjacent to an ocean into the ocean.

Return a 2D list of grid coordinates result where result[i] = [ri, ci] denotes that rain water can flow from cell (ri, ci) to both the Pacific and Atlantic oceans.

 

Example 1:

Input: heights = [[1,2,2,3,5],[3,2,3,4,4],[2,4,5,3,1],[6,7,1,4,5],[5,1,1,2,4]]
Output: [[0,4],[1,3],[1,4],[2,2],[3,0],[3,1],[4,0]]
Explanation: The following cells can flow to the Pacific and Atlantic oceans, as shown below:
[0,4]: [0,4] -> Pacific Ocean 
       [0,4] -> Atlantic Ocean
[1,3]: [1,3] -> [0,3] -> Pacific Ocean 
       [1,3] -> [1,4] -> Atlantic Ocean
[1,4]: [1,4] -> [1,3] -> [0,3] -> Pacific Ocean 
       [1,4] -> Atlantic Ocean
[2,2]: [2,2] -> [1,2] -> [0,2] -> Pacific Ocean 
       [2,2] -> [2,3] -> [2,4] -> Atlantic Ocean
[3,0]: [3,0] -> Pacific Ocean 
       [3,0] -> [4,0] -> Atlantic Ocean
[3,1]: [3,1] -> [3,0] -> Pacific Ocean 
       [3,1] -> [4,1] -> Atlantic Ocean
[4,0]: [4,0] -> Pacific Ocean 
       [4,0] -> Atlantic Ocean
Note that there are other possible paths for these cells to flow to the Pacific and Atlantic oceans.

Example 2:

Input: heights = [[1]]
Output: [[0,0]]
Explanation: The water can flow from the only cell to the Pacific and Atlantic oceans.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.PacificAtlanticWaterFlow
{
    public class Solution
    {
        public static IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var result = new List<IList<int>>();
            var rows = heights.Length;
            var cols = heights[0].Length;
            var pac = new HashSet<(int,int)>();
            var atl = new HashSet<(int,int)>();

            for (int i = 0; i< cols; i++)
            {
                dfs(0, i, pac, 0);
                dfs(rows-1, i, atl, 0);
            }
            for (int i = 0; i<rows; i++)
            {
                dfs(i, 0, pac, 0);
                dfs(i, cols-1, atl, 0);
            }

            return pac.Where(p => atl.Contains(p)).Select(p => (IList<int>)new List<int>{p.Item1,p.Item2}).ToList();

            void dfs(int row, int col, HashSet<(int,int)> hashset, int prevHeight)
            {
                if (row < 0 || row >= rows || col < 0 || col >= cols || 
                    hashset.Contains((row,col)) || prevHeight > heights[row][col]) return;
                hashset.Add((row,col));
                dfs(row + 1, col, hashset, heights[row][col]);
                dfs(row - 1, col, hashset, heights[row][col]);
                dfs(row, col + 1, hashset, heights[row][col]);
                dfs(row, col - 1, hashset, heights[row][col]);
                
            }
        }
    }

    public class Test
    {
        public static bool[] TestPacificAtlanticWaterFlow()
        {
            int[][] heights1 = new int[][]
            {
                new int[] { 1, 2, 2, 3, 5 },
                new int[] { 3, 2, 3, 4, 4 },
                new int[] { 2, 4, 5, 3, 1 },
                new int[] { 6, 7, 1, 4, 5 },
                new int[] { 5, 1, 1, 2, 4 }
            };

            int[][] heights2 = new int[][]
            {
                new int[] { 1 }
            };

            IList<IList<int>> result1_417 = Solution.PacificAtlantic(heights1);
            IList<IList<int>> result2_417 = Solution.PacificAtlantic(heights2);

            IList<IList<int>> expected1_417 = new List<IList<int>>
            {
                new List<int> { 0, 4 },
                new List<int> { 1, 3 },
                new List<int> { 1, 4 },
                new List<int> { 2, 2 },
                new List<int> { 3, 0 },
                new List<int> { 3, 1 },
                new List<int> { 4, 0 }
            };
            IList<IList<int>> expected2_417 = new List<IList<int>>
            {
                new List<int> { 0, 0 }
            };
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<int>>>(result1_417, result1_417),
                ResultTester.CheckResult<IList<IList<int>>>(result2_417, expected2_417)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Pacific Altantic Water Flow");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestPacificAtlanticWaterFlow());
        }
    }
}