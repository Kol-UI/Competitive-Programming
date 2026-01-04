// I Will Definitely Make It
namespace CompetitiveProgramming.CodeForces.IWillDefinitelyMakeIt;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0];
            long k = input[1];
            
            long[] heights = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long special = heights[k - 1];
            
            Array.Sort(heights);
            bool possible = true;
            
            for (int i = 1; i < n && possible; i++)
            {
                if (special > heights[i]) continue;
                if (heights[i] > heights[i - 1] + special) possible = false;
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("I Will Definitely Make It");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}