// Line Breaks
namespace CompetitiveProgramming.CodeForces.LineBreaks;
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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            
            int lastIndex = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (s.Length <= m)
                {
                    lastIndex = i + 1;
                    m -= s.Length;
                }
                else
                {
                    m = 0;
                }
            }
            
            Console.WriteLine(lastIndex);
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
        StyleHelper.Title("Line Breaks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}