// Maximize Area of Square Hole in Grid
namespace CompetitiveProgramming.LeetCode.MaximizeAreaofSquareHoleinGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximizeSquareHoleArea(int n, int m, int[] horizontal, int[] vertical)
    {
        int hMax = FindMaxSequence(horizontal);
        int vMax = FindMaxSequence(vertical);
        int side = Math.Min(hMax, vMax);
        return side * side;
    }

    private int FindMaxSequence(int[] bars)
    {
        Array.Sort(bars);
        int max = 2;
        int current = 1;
        for (int i = 1; i < bars.Length; i++)
        {
            if (bars[i - 1] + 1 == bars[i])
            {
                current++;
            }
            else
            {
                max = Math.Max(max, current + 1);
                current = 1;
            }
        }
        max = Math.Max(max, current + 1);
        return max;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaximizeSquareHoleArea(2, 1, [2,3], [2]), 4),
            ResultTester.CheckResult<int>(solution.MaximizeSquareHoleArea(1, 1, [2], [2]), 4),
            ResultTester.CheckResult<int>(solution.MaximizeSquareHoleArea(2, 3, [2,3], [2,4]), 4),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Area of Square Hole in Grid");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}