// Down with Brackets
namespace CompetitiveProgramming.CodeForces.DownwithBrackets;
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
            long cnt = 0;
            bool ans = true;
            for (int p = 1; p + 1 < s.Length; p++)
            {
                if (s[p] == '(') cnt++;
                else if (s[p] == ')') cnt--;
                if (cnt < 0) ans = false;
            }
            Console.WriteLine(ans ? "NO" : "YES");
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
        StyleHelper.Title("Down with Brackets");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}