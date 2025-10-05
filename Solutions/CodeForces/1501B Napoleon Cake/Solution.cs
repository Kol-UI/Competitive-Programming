// Napoleon Cake
namespace CompetitiveProgramming.CodeForces.NapoleonCake;
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
            long n = long.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long rem = 0;
            for (long p = n - 1; p >= 0; p--)
            {
                rem = Math.Max(rem, a[p]);
                a[p] = rem > 0 ? 1 : 0;
                rem--;
            }
            foreach (long num in a) Console.Write(num + " ");
            Console.WriteLine();
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
        StyleHelper.Title("Napoleon Cake");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}