// Make Them Equal
namespace CompetitiveProgramming.CodeForces.MakeThemEqual;
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
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            char c = char.Parse(input[1]);
            string s = Console.ReadLine();

            long last = -1;
            bool same = true;

            for (long p = s.Length - 1; p >= 0; p--)
            {
                if (s[(int)p] != c)
                {
                    same = false;
                }
                else if (last < 0)
                {
                    last = p + 1;
                }
            }

            if (same)
            {
                Console.WriteLine("0");
            }
            else if (2 * last > n)
            {
                Console.WriteLine($"1\n{last}");
            }
            else
            {
                Console.WriteLine($"2\n{n - 1} {n}");
            }
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
        StyleHelper.Title("Make Them Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}