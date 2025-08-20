// Premutation
namespace CompetitiveProgramming.CodeForces.Premutation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<long[]> m = new List<long[]>();
            
            for (int row = 0; row < n; row++)
            {
                long[] rowData = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
                m.Add(rowData);
            }

            long a = m[0][0], b = 0, first = 0;
            for (int row = 1; row < n && first == 0; row++)
            {
                long x = m[row][0];
                if (a == x) { first = a; break; }
                else if (b == x) { first = b; break; }
                else { b = x; }
            }

            Console.Write(first + " ");
            for (int row = 0; row < n; row++)
            {
                if (m[row][0] == first) continue;
                for (int col = 0; col < m[row].Length; col++)
                {
                    Console.Write(m[row][col] + " ");
                }
                break;
            }
            Console.WriteLine();
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
        StyleHelper.Title("Premutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}