// Largest Triangle Area
namespace CompetitiveProgramming.LeetCode.LargestTriangleArea;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public double LargestTriangleArea(int[][] points)
    {
        float resultArray = 0;
        for (int i = 0; i < points.Length-2; i++)
        {
            for (int j = i+1; j < points.Length-1; j++)
            {
                for (int k = j+1; k < points.Length; k++)
                {
                    float array = MathF.Abs((points[j][0] - points[i][0]) * (points[k][1] - points[i][1]) - (points[k][0] - points[i][0]) * (points[j][1] - points[i][1])) * 0.5f;
                    if (array > resultArray) resultArray = array;
                }
            }
        }

        return resultArray;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[][] points1 = new int[][]
        {
            new int[] {0, 0},
            new int[] {0, 1},
            new int[] {1, 0},
            new int[] {0, 2},
            new int[] {2, 0}
        };
        int[][] points2 = new int[][]
        {
            new int[] {1, 0},
            new int[] {0, 0},
            new int[] {0, 1}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<double>(solution.LargestTriangleArea(points1), 2.00000),
            ResultTester.CheckResult<double>(solution.LargestTriangleArea(points2), 0.50000),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Largest Triangle Area");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}