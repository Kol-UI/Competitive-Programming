// Image Overlap
namespace CompetitiveProgramming.LeetCode.ImageOverlap;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LargestOverlap(int[][] img1, int[][] img2)
    {
        int count = 0, N = img1.Length;
        var counts = new int[N * 2, N * 2];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
            {
                if (img1[i][j] == 0)
                    continue;

                for (int m = 0; m < N; m++)
                    for (int n = 0; n < N; n++)
                    {
                        if (img2[m][n] == 0)
                            continue;

                        count = Math.Max(count, ++counts[N + i - m, N + j - n]);
                    }
            }

        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LargestOverlap([[1,1,0],[0,1,0],[0,1,0]], [[0,0,0],[0,1,1],[0,0,1]]), 3),
            ResultTester.CheckResult<int>(solution.LargestOverlap([[1]], [[1]]), 1),
            ResultTester.CheckResult<int>(solution.LargestOverlap([[0]], [[0]]), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Image Overlap");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}