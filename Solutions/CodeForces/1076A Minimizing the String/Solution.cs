// Minimizing the String
namespace CompetitiveProgramming.CodeForces.MinimizingtheString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Text;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();

        int removeIdx = -1;
        for (int p = 0; p < n - 1; p++)
        {
            if (s[p] > s[p + 1])
            {
                removeIdx = p;
                break;
            }
        }
        if (removeIdx == -1) removeIdx = n - 1;

        StringBuilder sb = new StringBuilder(n - 1);
        for (int p = 0; p < n; p++)
        {
            if (p != removeIdx) sb.Append(s[p]);
        }

        Console.WriteLine(sb.ToString());
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
        StyleHelper.Title("Minimizing the String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}