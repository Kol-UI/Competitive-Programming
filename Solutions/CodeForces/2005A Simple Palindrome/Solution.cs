// Simple Palindrome
namespace CompetitiveProgramming.CodeForces.SimplePalindrome;
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
        string s = "aeiou";
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            int[] v = new int[5];
            for (int p = 0; p < 5; p++) v[p] = (int)(n / 5);
            for (int p = 0; p < n % 5; p++) v[p]++;
            for (int p = 0; p < 5; p++)
                for (int q = 0; q < v[p]; q++)
                    Console.Write(s[p]);
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
        StyleHelper.Title("Simple Palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}