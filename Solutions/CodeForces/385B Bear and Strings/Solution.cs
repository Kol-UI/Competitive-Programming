// Bear and Strings
namespace CompetitiveProgramming.CodeForces.BearandStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        const string name = "bear";
        string input = Console.ReadLine();

        int searchStart = 0;
        int found;
        long total = 0;
        while (true)
        {
            found = input.IndexOf(name, searchStart);
            if (found == -1) break;
            total += (long)(found - searchStart + 1) * (input.Length - found - name.Length + 1);
            searchStart = found + 1;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bear and Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}