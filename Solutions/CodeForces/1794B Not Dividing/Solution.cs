// Not Dividing
namespace CompetitiveProgramming.CodeForces.NotDividing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = Convert.ToInt64(Console.ReadLine());
        while (t-- > 0)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            List<long> a = Console.ReadLine().Split().Select(long.Parse).ToList();
            
            for (int p = 0; p < n; p++)
            {
                if (a[p] == 1)
                {
                    a[p] = 2;
                }
                
                if (p > 0 && a[p] % a[p - 1] == 0)
                {
                    a[p]++;
                }
            }

            Console.WriteLine(string.Join(" ", a));
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
        StyleHelper.Title("Not Dividing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}