// Currency System in Geraldion
namespace CompetitiveProgramming.CodeForces.CurrencySysteminGeraldion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        Console.ReadLine();
        string[] notes = Console.ReadLine().Split();
        long ans = 1;
        
        foreach (string noteStr in notes)
        {
            if (noteStr == "1")
            {
                ans = -1;
                break;
            }
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Currency System in Geraldion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}