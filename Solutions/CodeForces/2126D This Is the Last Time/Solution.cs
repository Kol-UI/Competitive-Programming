// This Is the Last Time
namespace CompetitiveProgramming.CodeForces.ThisIstheLastTime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

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
            
            List<long[]> v = new List<long[]>();
            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                long[] arr = new long[3];
                for (int u = 0; u < 3; u++)
                {
                    arr[u] = long.Parse(input[u]);
                }
                v.Add(arr);
            }
            
            v.Sort((a, b) =>
            {
                if (a[0] != b[0]) return a[0].CompareTo(b[0]);
                if (a[1] != b[1]) return a[1].CompareTo(b[1]);
                return a[2].CompareTo(b[2]);
            });
            
            for (long p = 0; p < n; p++)
            {
                if (k < v[(int)p][0] || k > v[(int)p][1]) continue;
                if (v[(int)p][2] > k) k = v[(int)p][2];
            }
            
            Console.WriteLine(k);
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
        StyleHelper.Title("This Is the Last Time");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}