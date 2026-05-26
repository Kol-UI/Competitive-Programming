// Substring and Subsequence
namespace CompetitiveProgramming.CodeForces.SubstringandSubsequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            long cnt = a.Length + b.Length;

            for (long start = 0; start < b.Length; start++)
            {
                long idx = start;
                for (int p = 0; p < a.Length; p++)
                {
                    if (idx < b.Length && a[p] == b[(int)idx])
                    {
                        idx++;
                    }
                }
                long total = a.Length + start + (b.Length - idx);
                if (total < cnt) cnt = total;
            }

            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Substring and Subsequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}