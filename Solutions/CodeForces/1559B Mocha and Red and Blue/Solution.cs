// Mocha and Red and Blue
namespace CompetitiveProgramming.CodeForces.MochaandRedandBlue;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            char[] s = Console.ReadLine().ToCharArray();
            long idx = 0;
            while (idx < n && s[idx] == '?') idx++;
            if (idx == n) s[--idx] = 'B';
            for (long p = idx - 1; p >= 0; p--)
            {
                if (s[p] == '?') s[p] = s[p + 1] == 'B' ? 'R' : 'B';
            }
            for (long p = idx + 1; p < n; p++)
            {
                if (s[p] == '?') s[p] = s[p - 1] == 'B' ? 'R' : 'B';
            }
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
        StyleHelper.Title("Mocha and Red and Blue");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}