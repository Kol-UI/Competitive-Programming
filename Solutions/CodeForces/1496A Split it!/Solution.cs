// Split it!
namespace CompetitiveProgramming.CodeForces.Splitit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            string str = Console.ReadLine()!;
            bool ok = true;
            ok &= (n > 2 * k);
            for (int i = 0; i < k; i++)
            {
                ok &= (str[i] == str[n - i - 1]);
            }
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Split it!");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}