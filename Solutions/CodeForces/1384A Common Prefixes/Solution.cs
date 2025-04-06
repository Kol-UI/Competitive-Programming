// Common Prefixes
namespace CompetitiveProgramming.CodeForces.CommonPrefixes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()@
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int mx = -1;
            foreach (int num in v)
            {
                mx = Math.Max(mx, num);
            }
            if (mx == 0) mx = 1;
            char[] x = new char[mx];
            Array.Fill(x, 'a');
            
            for (int i = -1; i < n; i++)
            {
                if (i != -1)
                {
                    for (int z = v[i]; z < mx; z++)
                    {
                        x[z] = (x[z] == 'a' ? 'b' : 'a');
                    }
                }
                Console.WriteLine(new string(x));
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Common Prefixes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}