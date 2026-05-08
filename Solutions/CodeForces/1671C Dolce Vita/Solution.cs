// Dolce Vita
namespace CompetitiveProgramming.CodeForces.DolceVita;
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
            long b = long.Parse(firstLine[1]);
            
            string[] secondLine = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(secondLine[p]));
            }
            a.Sort();
            
            long cs = 0;
            long total = 0;
            for (long p = 0; p < n; p++)
            {
                cs += a[(int)p];
                if (b < cs) break;
                total += 1 + (b - cs) / (p + 1);
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
        StyleHelper.Title("Dolce Vita");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}