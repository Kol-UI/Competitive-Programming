// Offshores
namespace CompetitiveProgramming.CodeForces.Offshores;
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
            long x = long.Parse(firstLine[1]);
            long y = long.Parse(firstLine[2]);
            
            string[] secondLine = Console.ReadLine().Split();
            long[] v = new long[n];
            long moved = 0;
            
            for (long p = 0; p < n; p++)
            {
                v[p] = long.Parse(secondLine[p]);
                moved += y * (v[p] / x);
            }
            
            long mxm = 0;
            foreach (long a in v)
            {
                long cur = a + moved - y * (a / x);
                if (cur > mxm) mxm = cur;
            }
            
            Console.WriteLine(mxm);
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
        StyleHelper.Title("Offshores");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}