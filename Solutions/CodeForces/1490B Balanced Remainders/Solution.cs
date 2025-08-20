// Balanced Remainders
namespace CompetitiveProgramming.CodeForces.BalancedRemainders;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] c = new long[3];
            long[] nums = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in nums) c[x % 3]++;

            long cnt = 0, carry = 0;
            for (int p = 0; p < 10; p++)
            {
                cnt += carry;
                c[p % 3] += carry;
                carry = 0;
                if (c[p % 3] > n / 3)
                {
                    long diff = c[p % 3] - n / 3;
                    carry += diff;
                    c[p % 3] -= diff;
                }
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Balanced Remainders");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}