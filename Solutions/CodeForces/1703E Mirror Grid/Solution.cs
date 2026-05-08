// Mirror Grid
namespace CompetitiveProgramming.CodeForces.MirrorGrid;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
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
            long n = long.Parse(Console.ReadLine());
            List<string> v = new List<string>();
            for (long p = 0; p < n; p++)
            {
                v.Add(Console.ReadLine());
            }
            
            long total = 0;
            for (long row = 0; row < n / 2; row++)
            {
                for (long col = row; col < n - 1 - row; col++)
                {
                    char a = v[(int)row][(int)col];
                    char b = v[(int)col][(int)(n - 1 - row)];
                    char c = v[(int)(n - 1 - row)][(int)(n - 1 - col)];
                    char d = v[(int)(n - 1 - col)][(int)row];
                    
                    int cntZ = (a == '1' ? 1 : 0) + (b == '1' ? 1 : 0) + (c == '1' ? 1 : 0) + (d == '1' ? 1 : 0);
                    int cntA = (a == '0' ? 1 : 0) + (b == '0' ? 1 : 0) + (c == '0' ? 1 : 0) + (d == '0' ? 1 : 0);
                    
                    total += (cntZ < cntA ? cntZ : cntA);
                }
            }
            
            Console.WriteLine(total);
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mirror Grid");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}