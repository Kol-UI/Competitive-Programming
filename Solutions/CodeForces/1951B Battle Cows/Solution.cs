// Battle Cows
namespace CompetitiveProgramming.CodeForces.BattleCows;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string[] nk = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long n = long.Parse(nk[0]);
            long k = long.Parse(nk[1]);

            string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            long[] a = new long[n];
            for (int p = 0; p < n; p++)
            {
                a[p] = long.Parse(parts[p]);
            }

            long b = a[--k];
            long first = n;
            long second = n;

            for (long p = 0; p < n; p++)
            {
                if (a[p] > b && first == n)
                {
                    first = p;
                }
                else if (a[p] > b)
                {
                    second = p;
                    break;
                }
            }

            long resA = first - 1;
            long resB = (second < k ? second : k) - first - (first == 0 ? 1 : 0);
            Console.WriteLine(resA > resB ? resA : resB);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Battle Cows");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}