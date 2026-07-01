// WeirdSort
namespace CompetitiveProgramming.CodeForces.WeirdSort;
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
            
            string[] input = Console.ReadLine().Split();
            List<long> a = new List<long>();
            for (long p = 0; p < n; p++)
            {
                a.Add(long.Parse(input[p]));
            }
            
            bool[] b = new bool[n];
            string[] positions = Console.ReadLine().Split();
            for (long p = 0; p < m; p++)
            {
                long pos = long.Parse(positions[p]);
                b[pos - 1] = true;
            }
            
            for (long p = 0; p < n; p++)
            {
                if (!b[p]) continue;
                long idx = p;
                while (idx < n && b[idx]) idx++;
                a.Sort((int)p, (int)(idx - p + 1), Comparer<long>.Default);
                p = idx;
            }
            
            bool res = true;
            for (long p = 1; p < n; p++)
            {
                if (a[(int)(p - 1)] > a[(int)p])
                {
                    res = false;
                    break;
                }
            }
            
            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("WeirdSort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}