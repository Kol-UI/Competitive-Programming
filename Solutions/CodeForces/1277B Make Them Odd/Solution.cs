// Make Them Odd
namespace CompetitiveProgramming.CodeForces.MakeThemOdd;
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
            
            SortedSet<long> s = new SortedSet<long>();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (x % 2 == 0)
                    s.Add(x);
            }
            
            long cnt = 0;
            while (s.Count > 0)
            {
                long x = s.Max;
                s.Remove(x);
                cnt++;
                x /= 2;
                if (x % 2 == 0)
                    s.Add(x);
            }
            
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Make Them Odd");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}