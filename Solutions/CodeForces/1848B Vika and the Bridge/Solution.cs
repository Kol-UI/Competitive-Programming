// Vika and the Bridge
namespace CompetitiveProgramming.CodeForces.VikaandtheBridge;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);
            
            long[] last = new long[k + 1];
            long[] first = new long[k + 1];
            long[] second = new long[k + 1];
            
            string[] input = Console.ReadLine().Split();
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(input[p - 1]);
                long dist = p - last[x] - 1;
                last[x] = p;
                if (dist >= first[x])
                {
                    second[x] = first[x];
                    first[x] = dist;
                }
                else if (dist >= second[x])
                {
                    second[x] = dist;
                }
            }
            
            for (long p = 1; p <= k; p++)
            {
                long dist = n - last[p];
                if (dist >= first[p])
                {
                    second[p] = first[p];
                    first[p] = dist;
                }
                else if (dist >= second[p])
                {
                    second[p] = dist;
                }
            }
            
            long ans = n;
            for (long p = 1; p <= k; p++)
            {
                long cur = second[p];
                if (cur <= first[p] / 2)
                {
                    cur = first[p] / 2;
                }
                if (cur < ans) ans = cur;
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Vika and the Bridge");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}