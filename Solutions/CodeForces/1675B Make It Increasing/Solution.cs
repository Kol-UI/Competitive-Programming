// Make It Increasing
namespace CompetitiveProgramming.CodeForces.MakeItIncreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine()!);
            long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long cnt = 0;
            bool invalid = false;

            for (int i = (int)n - 1; i > 0; )
            {
                if (arr[i] <= arr[i - 1] && arr[i - 1] > 0)
                {
                    arr[i - 1] /= 2;
                    cnt++;
                    continue;
                }
                else if (arr[i] == 0)
                {
                    Console.WriteLine("-1");
                    invalid = true;
                    break;
                }
                else
                {
                    i--;
                }
            }

            if (!invalid)
            {
                Console.WriteLine(cnt);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Divisors Interval");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}