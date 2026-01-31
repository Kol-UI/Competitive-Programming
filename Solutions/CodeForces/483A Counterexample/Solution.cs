// Counterexample
namespace CompetitiveProgramming.CodeForces.Counterexample;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long l = input[0];
        long r = input[1];
        
        if(l % 2 == 0 && (r - l) >= 2)
        {
            Console.WriteLine($"{l} {l + 1} {l + 2}");
        }
        else if(l % 2 == 1 && (r - l) >= 3)
        {
            Console.WriteLine($"{l + 1} {l + 2} {l + 3}");
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Counterexample");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}