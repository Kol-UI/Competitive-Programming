// Index and Maximum Value
namespace CompetitiveProgramming.CodeForces.IndexandMaximumValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
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
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long m = long.Parse(input[1]);
            long x = 0;
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long a in arr) x = Math.Max(x, a);
            for (long i = 0; i < m; i++)
            {
                string[] query = Console.ReadLine().Split();
                char c = query[0][0];
                long l = long.Parse(query[1]);
                long r = long.Parse(query[2]);
                if (l <= x && x <= r)
                {
                    if (c == '+') x++;
                    else if (c == '-') x--;
                }
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Index and Maximum Value");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}