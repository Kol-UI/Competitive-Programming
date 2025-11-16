// Crafting
namespace CompetitiveProgramming.CodeForces.Crafting;
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
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long[] diff = new long[n];
            for (int i = 0; i < n; i++)
            {
                diff[i] = a[i] - b[i];
            }
            
            bool valid = true;
            long maxNegative = 0;
            
            for (int i = 0; i < n; i++)
            {
                if (diff[i] < 0)
                {
                    if (maxNegative != 0) valid = false;
                    else maxNegative = diff[i];
                }
            }
            
            for (int i = 0; valid && i < n; i++)
            {
                if (diff[i] >= 0 && diff[i] + maxNegative < 0)
                {
                    valid = false;
                }
            }
            
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
        StyleHelper.Title("Crafting");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}