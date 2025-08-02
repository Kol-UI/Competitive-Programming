// Matrix Game
namespace CompetitiveProgramming.CodeForces.MatrixGame;

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
            int[] nm = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nm[0], m = nm[1];
            bool[] rows = new bool[n];
            bool[] cols = new bool[m];
            Array.Fill(rows, true);
            Array.Fill(cols, true);

            for (int row = 0; row < n; row++)
            {
                int[] x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                for (int col = 0; col < m; col++)
                {
                    if (x[col] != 0)
                    {
                        rows[row] = false;
                        cols[col] = false;
                    }
                }
            }

            int u = 0, v = 0;
            for (int p = 0; p < n; p++) if (rows[p]) u++;
            for (int p = 0; p < m; p++) if (cols[p]) v++;

            int turns = Math.Min(u, v);
            Console.WriteLine(turns % 2 == 1 ? "Ashish" : "Vivek");
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
        StyleHelper.Title("Matrix Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}