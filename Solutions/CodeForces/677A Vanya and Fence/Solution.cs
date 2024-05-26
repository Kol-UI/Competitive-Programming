// Vanya and Fence

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.VanyaandFence;

class Program
{
    /*
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split();
        int n = int.Parse(inputs[0]);
        int h = int.Parse(inputs[1]);

        string[] heights = Console.ReadLine().Split();
        int width = 0;

        for (int i = 0; i < n; i++)
        {
            int height = int.Parse(heights[i]);
            if (height > h)
                width += 2;
            else
                width += 1;
        }

        Console.WriteLine(width);
    }
    */
}


public class Test
{
    public static int CalculateFenceWidth(int n, int h, int[] heights)
    {
        int width = 0;

        for (int i = 0; i < n; i++)
        {
            if (heights[i] > h)
                width += 2;
            else
                width += 1;
        }

        return width;
    }

    public static bool[] TestCases()
    {
        int[] testHeights1 = { 4, 5, 14 };
        int[] testHeights2 = { 3, 3, 3 };
        int[] testHeights3 = { 7, 6, 8, 9, 10, 5 };
        int[] testHeights4 = { 214, 614, 297, 675, 82, 740, 174, 23, 255, 15 };
        int[] testHeights5 = { 657, 23, 1096, 487, 785, 66, 481, 554, 1000, 821 };
        int[] testHeights6 = { 1, 1, 1, 1, 1, 1 };

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(3, 7, testHeights1), 4),
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(3, 2, testHeights2), 6),
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(6, 5, testHeights3), 11),
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(10, 420, testHeights4), 13),
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(10, 561, testHeights5), 15),
            ResultTester.CheckResult<int>(Test.CalculateFenceWidth(6, 1, testHeights6), 6),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vanya and Fence");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}