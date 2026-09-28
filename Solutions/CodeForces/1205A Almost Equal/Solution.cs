// Almost Equal
namespace CompetitiveProgramming.CodeForces.AlmostEqual;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string nLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nLine)) return;

        long n = long.Parse(nLine.Trim());
        if (n % 2 != 0)
        {
            Console.WriteLine("YES");
            long[] a = new long[2 * n];
            for (int p = 0; p < n; p++)
            {
                if (p % 2 != 0)
                {
                    a[p] = 2 * p + 2;
                    a[p + n] = 2 * p + 1;
                }
                else
                {
                    a[p] = 2 * p + 1;
                    a[p + n] = 2 * p + 2;
                }
            }
            Console.WriteLine(string.Join(" ", a));
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Almost Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}