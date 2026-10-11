// K-th Beautiful String
namespace CompetitiveProgramming.CodeForces.KthBeautifulString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] first = Console.ReadLine().Split();
            long n = long.Parse(first[0]);
            long k = long.Parse(first[1]);

            char[] s = new char[n];
            for (long i = 0; i < n; i++) s[i] = 'a';

            long pos = 0;
            while (pos < k)
            {
                k -= pos;
                pos++;
            }
            s[(int)((n - 1) - pos)] = 'b';
            s[(int)((n - 1) - (k - 1))] = 'b';

            Console.WriteLine(new string(s));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("K-th Beautiful String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}