// Book Reading
namespace CompetitiveProgramming.CodeForces.BookReading;
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
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);

            long b = n / m;
            long s = 0;
            long[] a = new long[10];

            for (long p = 0; p < 10; p++)
            {
                a[p] = ((p + 1) * m) % 10;
                s += a[p];
            }

            long t = (b / 10) * s;
            b %= 10;

            for (long p = 0; p < b; p++)
            {
                t += a[p];
            }

            Console.WriteLine(t);
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
        StyleHelper.Title("Book Reading");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}