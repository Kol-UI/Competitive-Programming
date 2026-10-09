// Good Start
namespace CompetitiveProgramming.CodeForces.GoodStart;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string tLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(tLine)) return;

        long t = long.Parse(tLine.Trim());
        while (t-- > 0)
        {
            string line1 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line1)) line1 = Console.ReadLine();
            string[] parts1 = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long w = long.Parse(parts1[0]);
            long h = long.Parse(parts1[1]);
            long a = long.Parse(parts1[2]);
            long b = long.Parse(parts1[3]);

            string line2 = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(line2)) line2 = Console.ReadLine();
            string[] parts2 = line2.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            long x1 = long.Parse(parts2[0]);
            long y1 = long.Parse(parts2[1]);
            long x2 = long.Parse(parts2[2]);
            long y2 = long.Parse(parts2[3]);

            if (x1 == x2)
            {
                Console.WriteLine((y1 - y2) % b != 0 ? "No" : "Yes");
            }
            else if (y1 == y2)
            {
                Console.WriteLine((x1 - x2) % a != 0 ? "No" : "Yes");
            }
            else
            {
                Console.WriteLine(((x1 - x2) % a != 0) && ((y1 - y2) % b != 0) ? "No" : "Yes");
            }
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Good Start");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}