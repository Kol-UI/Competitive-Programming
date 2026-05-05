// Removing Smallest Multiples
namespace CompetitiveProgramming.CodeForces.RemovingSmallestMultiples;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            s = "a" + s;

            long cnt = 0;
            char[] arr = s.ToCharArray();

            for (long p = 1; p < arr.Length; p++)
            {
                if (arr[p] == '1') continue;
                for (long q = p; q < arr.Length && arr[q] != '1'; q += p)
                {
                    if (arr[q] == '0')
                        cnt += p;
                    arr[q] = 'x';
                }
            }

            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Removing Smallest Multiples");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}