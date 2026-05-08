// M-arrays
namespace CompetitiveProgramming.CodeForces.Marrays;
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
            long m = long.Parse(firstLine[1]);
            
            long[] v = new long[m];
            string[] input = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                v[x % m]++;
            }
            
            long cnt = v[0] > 0 ? 1 : 0;
            for (long p = 1; p <= m - p; p++)
            {
                if (p == m - p && v[p] > 0)
                {
                    cnt++;
                }
                else if (v[p] > 0 || v[m - p] > 0)
                {
                    cnt++;
                    long rem = v[p] - v[m - p];
                    if (rem < 0) rem = -rem;
                    if (rem > 1) cnt += rem - 1;
                }
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
        StyleHelper.Title("M-arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}