// Vasilije in Cacak
namespace CompetitiveProgramming.CodeForces.VasilijeinCacak;
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
            long[] input = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long n = input[0], k = input[1], x = input[2];
            long temp = n * (n + 1) / 2;
            long zz = (n - k) * (n - k + 1) / 2;
            
            if (temp < x || (k * (k + 1) / 2 > x) || temp - x < zz)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vasilije in Cacak");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}