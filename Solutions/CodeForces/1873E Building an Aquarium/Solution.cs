// Building an Aquarium
namespace CompetitiveProgramming.CodeForces.BuildinganAquarium;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            long n = long.Parse(input[0]);
            long x = long.Parse(input[1]);
            long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);

            long ans = 0;
            long low = 0, high = (long)1e18;
            while (low <= high)
            {
                long mid = low + (high - low) / 2;
                long temp = x;
                for (int i = 0; i < n; i++)
                {
                    if (v[i] > mid) continue;
                    temp -= (mid - v[i]);
                    if (temp < 0) break;
                }
                if (temp < 0)
                {
                    high = mid - 1;
                }
                else
                {
                    ans = Math.Max(ans, mid);
                    low = mid + 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Building an Aquarium");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}