// Number of Black Blocks
namespace CompetitiveProgramming.LeetCode.NumberofBlackBlocks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long[] CountBlackBlocks(int rows, int cols, int[][] points)
    {
        HashSet<long> black = new HashSet<long>();
        foreach (var p in points)
        {
            black.Add(p[0] * 100000L + p[1]);
        }

        long[] counts = new long[5];
        long total = (rows - 1L) * (cols - 1);

        foreach (var p in points)
        {
            long key = p[0] * 100000L;
            long keyUp = (p[0] + 1) * 100000L;
            long keyDown = (p[0] - 1) * 100000L;

            if (p[0] != rows - 1 && p[1] != cols - 1)
            {
                int b = 1;
                if (black.Contains(keyUp + p[1] + 1)) b++;
                if (black.Contains(key + p[1] + 1)) b++;
                if (black.Contains(keyUp + p[1])) b++;
                counts[b]++;
            }

            if (p[0] != rows - 1 && p[1] != 0 && !black.Contains(key + p[1] - 1))
            {
                int b = 1;
                if (black.Contains(keyUp + p[1] - 1)) b++;
                if (black.Contains(keyUp + p[1])) b++;
                counts[b]++;
            }

            if (p[0] != 0 && p[1] != cols - 1 && !black.Contains(keyDown + p[1] + 1) && !black.Contains(keyDown + p[1]))
            {
                int b = 1;
                if (black.Contains(key + p[1] + 1)) b++;
                counts[b]++;
            }

            if (p[0] != 0 && p[1] != 0 && !black.Contains(keyDown + p[1] - 1) && !black.Contains(keyDown + p[1]) && !black.Contains(key + p[1] - 1))
            {
                counts[1]++;
            }
        }

        counts[0] = total - counts[1] - counts[2] - counts[3] - counts[4];
        return counts;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] case1 = new int[][]
        {
            new int[] {0, 0}
        };
        int[][] case2 = new int[][]
        {
            new int[] {0, 0},
            new int[] {1, 1},
            new int[] {0, 2}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long[]>(solution.CountBlackBlocks(3, 3, case1), [3,1,0,0,0]),
            ResultTester.CheckResult<long[]>(solution.CountBlackBlocks(3, 3, case2), [0,2,2,0,0])
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Black Blocks");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}