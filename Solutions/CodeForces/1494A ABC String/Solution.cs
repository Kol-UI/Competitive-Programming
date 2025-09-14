// ABC String
namespace CompetitiveProgramming.CodeForces.ABCString;
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
            string s = Console.ReadLine()!;
            int[] f = new int[3];
            f[s[0] - 'A'] = 1;
            f[s[s.Length - 1] - 'A'] = -1;
            long cnt = 0;
            foreach (char c in s) cnt += f[c - 'A'];
            for (int p = 0; p < 3; p++)
            {
                if (f[p] == 0) f[p] = cnt > 0 ? -1 : 1;
            }
            cnt = 0;
            string res = "YES";
            foreach (char c in s)
            {
                cnt += f[c - 'A'];
                if (cnt < 0)
                {
                    res = "NO";
                    break;
                }
            }
            if (cnt != 0) res = "NO";
            Console.WriteLine(res);
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
        StyleHelper.Title("ABC String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}