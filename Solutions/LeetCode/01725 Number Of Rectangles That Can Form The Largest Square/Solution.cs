// Number Of Rectangles That Can Form The Largest Square
namespace CompetitiveProgramming.LeetCode.NumberOfRectanglesThatCanFormTheLargestSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountGoodRectangles(int[][] rectangles)
    {
        List<int> list = new List<int>();
        foreach (var item in rectangles)
        {
            if (item[0] >= item[1])
            {
                list.Add(item[1]);
            }
            else
            {
                list.Add(item[0]);
            }
        }

        int count = 0;
        int maxLength = list.Max();
        foreach (var item in list)
        {
            if (item == maxLength)
            {
                count++;
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
        int[][] rectangles1 = new int[][]
        {
            new int[] {5, 8},
            new int[] {3, 9},
            new int[] {5, 12},
            new int[] {16, 5}
        };

        int[][] rectangles2 = new int[][]
        {
            new int[] {2, 3},
            new int[] {3, 7},
            new int[] {4, 3},
            new int[] {3, 7}
        };
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountGoodRectangles(rectangles1), 3),
            ResultTester.CheckResult<int>(solution.CountGoodRectangles(rectangles2), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number Of Rectangles That Can Form The Largest Square");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}