// New Theatre Square
namespace CompetitiveProgramming.CodeForces.NewTheatreSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0], m = input[1], x = input[2], y = input[3];
            long cost = 0;
            long dbl = 2 * x < y ? 2 * x : y;

            for (int p = 0; p < n; p++)
            {
                string row = Console.ReadLine();
                long cnt = 0;
                for (int u = 0; u < row.Length; u++)
                {
                    if (row[u] == '*')
                    {
                        cost += (cnt / 2) * dbl + (cnt % 2) * x;
                        cnt = 0;
                    }
                    else
                    {
                        cnt++;
                    }
                }
                cost += (cnt / 2) * dbl + (cnt % 2) * x;
            }

            Console.WriteLine(cost);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("New Theatre Square");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}