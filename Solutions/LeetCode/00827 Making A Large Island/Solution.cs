// Making A Large Island

namespace CompetitiveProgramming.LeetCode.MakingALargeIsland;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private static readonly int[][] Directions =
    {
        new[] { 0, 1 }, new[] { 0, -1 }, new[] { 1, 0 }, new[] { -1, 0 }
    };
    
    public int LargestIsland(int[][] grid)
    {
        int n = grid.Length;
        int index = 2; 
        Dictionary<int, int> islandSize = new();
        bool hasZero = false;
        int maxIsland = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 1)
                {
                    int size = MarkIsland(grid, i, j, index);
                    islandSize[index] = size;
                    maxIsland = Math.Max(maxIsland, size);
                    index++;
                }
                else
                {
                    hasZero = true;
                }
            }
        }

        if (!hasZero) return maxIsland;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    maxIsland = Math.Max(maxIsland, ComputeNewIslandSize(grid, i, j, islandSize));
                }
            }
        }

        return maxIsland;
    }

    private int MarkIsland(int[][] grid, int i, int j, int index)
    {
        int n = grid.Length;
        if (i < 0 || i >= n || j < 0 || j >= n || grid[i][j] != 1) return 0;

        grid[i][j] = index; 
        int size = 1;
        foreach (var dir in Directions)
        {
            size += MarkIsland(grid, i + dir[0], j + dir[1], index);
        }

        return size;
    }

    private int ComputeNewIslandSize(int[][] grid, int i, int j, Dictionary<int, int> islandSize)
    {
        int newSize = 1; 
        HashSet<int> seenIslands = new();
        int n = grid.Length;

        foreach (var dir in Directions)
        {
            int ni = i + dir[0], nj = j + dir[1];
            if (ni >= 0 && ni < n && nj >= 0 && nj < n && grid[ni][nj] > 1)
            {
                if (seenIslands.Add(grid[ni][nj]))
                { 
                    newSize += islandSize[grid[ni][nj]];
                }
            }
        }

        return newSize;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Making A Large Island");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}