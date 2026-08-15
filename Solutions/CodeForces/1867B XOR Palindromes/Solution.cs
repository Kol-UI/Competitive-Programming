// XOR Palindromes
namespace CompetitiveProgramming.CodeForces.XORPalindromes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            long cnt = 0;
            for (long p = 0; p < n - 1 - p; p++)
            {
                if (s[(int)p] != s[(int)(n - 1 - p)])
                    cnt++;
            }

            char[] res = new char[n + 1];
            for (int i = 0; i <= n; i++)
                res[i] = '0';

            for (long p = cnt; p + cnt <= n; p++)
            {
                if ((n % 2 == 1) || ((p - cnt) % 2 == 0))
                    res[p] = '1';
            }

            Console.WriteLine(new string(res));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("XOR Palindromes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}