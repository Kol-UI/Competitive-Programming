// Uninteresting Number
namespace CompetitiveProgramming.CodeForces.UninterestingNumber;
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
            string w = Console.ReadLine();
            long d = 0, r = 0, s = 0;
            
            for (long p = 0; p < w.Length; p++)
            {
                int x = w[(int)p] - '0';
                s += x;
                if (x == 2) d++;
                if (x == 3) r++;
            }
            
            s %= 9;
            bool possible = false;
            
            if (s == 0) possible = true;
            else if (s == 1 && (d > 3 || (d > 0 && r > 0))) possible = true;
            else if (s == 2 && (d >= 8 || (d >= 5 && r >= 1) || (d >= 2 && r >= 2))) possible = true;
            else if (s == 3 && (d >= 3 || r >= 1)) possible = true;
            else if (s == 4 && (d >= 7 || (d >= 4 && r >= 1) || (d >= 1 && r >= 2))) possible = true;
            else if (s == 5 && d >= 2) possible = true;
            else if (s == 6 && (d >= 6 || (d >= 3 && r >= 1) || (r >= 2))) possible = true;
            else if (s == 7 && d > 0) possible = true;
            else if (s == 8 && (d >= 5 || (d >= 2 && r >= 1))) possible = true;
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Uninteresting Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}