// Not a Substring
namespace CompetitiveProgramming.CodeForces.NotaSubstring;
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
            string x = new string('(', s.Length) + new string(')', s.Length);
            string y = "";
            for (long p = 0; p < s.Length; p++) y += "()";
            if (!x.Contains(s)) Console.WriteLine("YES\n" + x);
            else if (!y.Contains(s)) Console.WriteLine("YES\n" + y);
            else Console.WriteLine("NO");
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
        StyleHelper.Title("Not a Substring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}