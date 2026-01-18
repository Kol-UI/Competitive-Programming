// Array Recovery
namespace CompetitiveProgramming.CodeForces.ArrayRecovery;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.IO;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long[] a = new long[n];
            a[0] = input[0];
            bool unique = true;
            
            for(int p = 1; p < n; p++)
            {
                long diff = input[p];
                if(diff > 0 && diff <= a[p - 1])
                {
                    unique = false;
                }
                a[p] = a[p - 1] + diff;
            }
            
            if(unique)
            {
                Console.WriteLine(string.Join(" ", a.Select(x => x.ToString()).ToArray()));
            }
            else
            {
                Console.WriteLine("-1");
            }
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
        StyleHelper.Title("Array Recovery");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}