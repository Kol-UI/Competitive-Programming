// Reversing Encryption
namespace CompetitiveProgramming.CodeForces.ReversingEncryption;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();
        
        for (int d = 1; d <= n; d++)
        {
            if (n % d == 0)
            {
                Array.Reverse(s, 0, d);
            }
        }
        
        Console.WriteLine(new string(s));
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reversing Encryption");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}