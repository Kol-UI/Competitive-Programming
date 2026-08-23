// Skibidus and Sigma
namespace CompetitiveProgramming.CodeForces.SkibidusandSigma;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);
            
            List<long> v = new List<long>();
            long total = 0;
            
            for (long p = 0; p < n; p++)
            {
                string[] row = Console.ReadLine().Split();
                long sum = 0;
                for (long q = 0; q < m; q++)
                {
                    long x = long.Parse(row[q]);
                    total += (m - q) * x;
                    sum += x;
                }
                v.Add(sum);
            }
            
            v.Sort((a, b) => b.CompareTo(a));
            
            for (long p = 0; p < n; p++)
            {
                total += (n - 1 - p) * m * v[(int)p];
            }
            
            Console.WriteLine(total);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Skibidus and Sigma");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}