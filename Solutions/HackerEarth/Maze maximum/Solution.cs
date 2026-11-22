// Maze maximum
namespace CompetitiveProgramming.HackerEarth.Mazemaximum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        long[] rowMin = new long[n];
        long[] colMin = new long[m];

        for (int i = 0; i < n; i++)
        {
            rowMin[i] = long.MaxValue;
        }

        for (int j = 0; j < m; j++)
        {
            colMin[j] = long.MaxValue;
        }

        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < m; j++)
            {
                long value = long.Parse(parts[j]);
                if (value < rowMin[i]) rowMin[i] = value;
                if (value < colMin[j]) colMin[j] = value;
            }
        }

        Console.WriteLine(Math.Min(rowMin.Max(), colMin.Max()));
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maze maximum");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}