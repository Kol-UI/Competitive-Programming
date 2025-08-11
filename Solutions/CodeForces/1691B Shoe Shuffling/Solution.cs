// Shoe Shuffling
namespace CompetitiveProgramming.CodeForces.ShoeShuffling;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> v = new List<long>(Array.ConvertAll(Console.ReadLine().Split(), long.Parse));
            v.Add(1000000007);
            int sz = 1, start = 0;
            bool possible = true;
            List<long> w = new List<long>();

            for (int p = 1; p <= n; p++)
            {
                if (v[p] == v[p - 1])
                {
                    sz++;
                    continue;
                }
                if (sz == 1)
                {
                    possible = false;
                    break;
                }
                w.Add(p);
                for (int u = start; u < p - 1; u++)
                {
                    w.Add(u + 1);
                }
                start = p;
                sz = 1;
            }

            if (possible)
            {
                Console.WriteLine(string.Join(" ", w));
            }
            else
            {
                Console.WriteLine("-1");
            }
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
        StyleHelper.Title("Shoe Shuffling");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}