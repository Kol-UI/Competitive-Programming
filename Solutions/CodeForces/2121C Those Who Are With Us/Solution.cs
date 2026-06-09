// Those Who Are With Us
namespace CompetitiveProgramming.CodeForces.ThoseWhoAreWithUs;
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
            
            long[][] f = new long[n][];
            long mx = 0;
            
            for (long row = 0; row < n; row++)
            {
                f[row] = new long[m];
                string[] rowInput = Console.ReadLine().Split();
                for (long col = 0; col < m; col++)
                {
                    f[row][col] = long.Parse(rowInput[col]);
                    if (f[row][col] > mx) mx = f[row][col];
                }
            }
            
            long[] vr = new long[n];
            long[] vc = new long[m];
            long mxcnt = 0;
            
            for (long row = 0; row < n; row++)
            {
                for (long col = 0; col < m; col++)
                {
                    if (f[row][col] < mx) continue;
                    vr[row]++;
                    vc[col]++;
                    mxcnt++;
                }
            }
            
            bool single = false;
            for (long row = 0; !single && row < n; row++)
            {
                for (long col = 0; !single && col < m; col++)
                {
                    long val = vr[row] + vc[col];
                    if (f[row][col] == mx) val--;
                    if (val == mxcnt) single = true;
                }
            }
            
            Console.WriteLine(mx - (single ? 1 : 0));
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
        StyleHelper.Title("Those Who Are With Us");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}