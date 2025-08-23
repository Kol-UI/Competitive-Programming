// Not Quite a Palindromic String
namespace CompetitiveProgramming.CodeForces.NotQuiteaPalindromicString;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long n = long.Parse(input[0]);
            long k = long.Parse(input[1]);
            string s = Console.ReadLine();
            long z = 0, a = 0;
            foreach (char c in s)
            {
                if (c == '0') z++;
                if (c == '1') a++;
            }
            long d = n / 2 - k;
            bool possible = (z >= d) && (a >= d) && ((a - d) % 2 == 0) && ((z - d) % 2 == 0);
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Not Quite a Palindromic String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}