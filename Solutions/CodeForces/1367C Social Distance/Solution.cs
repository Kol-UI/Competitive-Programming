// Social Distance
namespace CompetitiveProgramming.CodeForces.SocialDistanceII;
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

            char[] s = Console.ReadLine().ToCharArray();

            long last = -k - 7;
            for (long p = 0; p < s.Length; p++)
            {
                if (s[(int)p] == '1') last = p;
                else if (p <= last + k) s[(int)p] = '2';
            }

            long cnt = 0;
            last = s.Length + k + 7;
            for (long p = s.Length - 1; p >= 0; p--)
            {
                if (s[(int)p] == '1') last = p;
                else if (p + k < last && s[(int)p] == '0') { cnt++; last = p; }
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Social Distance");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}