// Infinite Replacement
namespace CompetitiveProgramming.CodeForces.InfiniteReplacement;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            
            long result;
            if (t.Length == 1 && t[0] == 'a')
            {
                result = 1;
            }
            else if (t.Contains('a'))
            {
                result = -1;
            }
            else
            {
                result = 1L << s.Length;
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Infinite Replacement");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}