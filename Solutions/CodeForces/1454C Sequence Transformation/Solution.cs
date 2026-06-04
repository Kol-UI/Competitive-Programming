// Sequence Transformation
namespace CompetitiveProgramming.CodeForces.SequenceTransformation;
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
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            
            Dictionary<long, long> cm = new Dictionary<long, long>();
            long prev = long.Parse(input[0]);
            cm[prev] = 0;
            long x = prev;
            
            for (long p = 1; p < n; p++)
            {
                x = long.Parse(input[p]);
                if (x != prev)
                {
                    if (!cm.ContainsKey(x))
                        cm[x] = 0;
                    cm[x]++;
                }
                prev = x;
            }
            
            long mn = n + 1;
            foreach (var kvp in cm)
            {
                long num = kvp.Value + (kvp.Key != x ? 1 : 0);
                if (num < mn) mn = num;
            }
            
            Console.WriteLine(mn);
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
        StyleHelper.Title("Sequence Transformation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}