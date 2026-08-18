// Buying Lemonade
namespace CompetitiveProgramming.CodeForces.BuyingLemonade;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long k = long.Parse(firstLine[1]);

            string[] input = Console.ReadLine().Split();
            List<long> v = new List<long>();
            for (long p = 0; p < n; p++)
                v.Add(long.Parse(input[p]));

            v.Sort();

            long cnt = 0;
            long prev = 0;

            for (long p = 0; p < n; p++)
            {
                long diff = v[(int)p] - prev;
                prev = v[(int)p];
                long num = diff * (n - p);

                if (k <= num)
                {
                    cnt += k;
                    break;
                }
                else
                {
                    cnt += num + 1;
                    k -= num;
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
        StyleHelper.Title("Buying Lemonade");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
