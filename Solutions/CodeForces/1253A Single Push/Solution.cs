// Single Push
namespace CompetitiveProgramming.CodeForces.SinglePush;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            for (int i = 0; i < n; i++) a[i] -= b[i];
            
            bool valid = true;
            for (int i = 0; i < n; i++)
            {
                if (a[i] < 0)
                {
                    long diff = a[i];
                    for (int j = i; j < n; j++)
                    {
                        if (a[j] == diff) a[j] = 0;
                        else if (a[j] == 0) break;
                        else valid = false;
                    }
                    break;
                }
            }
            
            for (int i = 0; i < n; i++) if (a[i] != 0) valid = false;
            
            Console.WriteLine(valid ? "YES" : "NO");
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
        StyleHelper.Title("Single Push");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}