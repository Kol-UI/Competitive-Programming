// AB Flipping
namespace CompetitiveProgramming.CodeForces.ABFlipping;
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
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            int count = n - 1;
            
            for (int position = 0; count > 0 && position < s.Length && s[position] == 'B'; position++)
            {
                count--;
            }
            
            for (int position = n - 1; count > 0 && position >= 0 && s[position] == 'A'; position--)
            {
                count--;
            }
            
            Console.WriteLine(count);
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
        StyleHelper.Title("AB Flipping");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}