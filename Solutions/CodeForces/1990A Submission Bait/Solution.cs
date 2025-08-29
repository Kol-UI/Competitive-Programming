// Submission Bait
namespace CompetitiveProgramming.CodeForces.SubmissionBait;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] v = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            if (n % 2 != 0)
            {
                Console.WriteLine("YES");
                continue;
            }
            Array.Sort(v);
            Array.Reverse(v);
            bool res = false;
            for (long p = 1; !res && p < n; p += 2)
            {
                if (v[p - 1] == v[p]) continue;
                res = true;
            }
            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Submission Bait");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}