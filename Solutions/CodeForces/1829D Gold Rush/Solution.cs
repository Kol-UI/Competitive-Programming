// Gold Rush
namespace CompetitiveProgramming.CodeForces.GoldRush;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long Gcd(long a, long b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0], m = input[1];
            long g = Gcd(m, n);
            n /= g; m /= g;
            
            int fn = 0;
            while (n % 3 == 0) { fn++; n /= 3; }
            
            int fm = 0;
            while (m % 2 == 0) { fm++; m /= 2; }
            
            Console.WriteLine(n == 1 && m == 1 && fm <= fn ? "YES" : "NO");
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
        StyleHelper.Title("Gold Rush");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}