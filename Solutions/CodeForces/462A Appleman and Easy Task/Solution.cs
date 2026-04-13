// Appleman and Easy Task
namespace CompetitiveProgramming.CodeForces.ApplemanandEasyTask;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8601
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] checkboard = new string[n];
        for (int p = 0; p < n; p++)
        {
            checkboard[p] = Console.ReadLine();
        }

        bool allEven = true;

        for (int row = 0; row < n; row++)
        {
            if (!allEven) break;
            for (int col = 0; col < n; col++)
            {
                int adjacent = 0;
                if (row > 0 && checkboard[row - 1][col] == 'o') adjacent++;
                if (row < n - 1 && checkboard[row + 1][col] == 'o') adjacent++;
                if (col > 0 && checkboard[row][col - 1] == 'o') adjacent++;
                if (col < n - 1 && checkboard[row][col + 1] == 'o') adjacent++;

                if (adjacent % 2 > 0)
                {
                    allEven = false;
                    break;
                }
            }
        }

        Console.WriteLine(allEven ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8601
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Appleman and Easy Task");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}