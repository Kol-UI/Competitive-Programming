// Dual Trigger
namespace CompetitiveProgramming.CodeForces.DualTrigger;
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
            string s = Console.ReadLine()!;
            long cnt = 0;
            bool adj = false;
            for (int p = 0; p < n; p++)
            {
                if (s[p] == '1') cnt++;
                if (p > 0 && s[p - 1] == '1' && s[p] == '1') adj = true;
            }
            if (cnt == 2 && adj) Console.WriteLine("NO");
            else Console.WriteLine(cnt % 2 == 0 ? "YES" : "NO");
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
        StyleHelper.Title("Dual Trigger");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}