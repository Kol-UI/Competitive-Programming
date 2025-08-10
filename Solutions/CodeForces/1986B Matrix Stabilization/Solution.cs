// Matrix Stabilization
namespace CompetitiveProgramming.CodeForces.MatrixStabilization;
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
            long[][] v = new long[n][];
            
            for (int row = 0; row < n; row++)
            {
                v[row] = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    bool largest = true;
                    long mx = 0;
                    
                    if (row > 0 && v[row - 1][col] >= v[row][col])
                        largest = false;
                    else if (row > 0)
                        mx = Math.Max(mx, v[row - 1][col]);

                    if (row + 1 < n && v[row + 1][col] >= v[row][col])
                        largest = false;
                    else if (row + 1 < n)
                        mx = Math.Max(mx, v[row + 1][col]);

                    if (col > 0 && v[row][col - 1] >= v[row][col])
                        largest = false;
                    else if (col > 0)
                        mx = Math.Max(mx, v[row][col - 1]);

                    if (col + 1 < m && v[row][col + 1] >= v[row][col])
                        largest = false;
                    else if (col + 1 < m)
                        mx = Math.Max(mx, v[row][col + 1]);

                    if (largest) 
                        v[row][col] = mx;

                    Console.Write(v[row][col] + " ");
                }
                Console.WriteLine();
            }
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
        StyleHelper.Title("Matrix Stabilization");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}