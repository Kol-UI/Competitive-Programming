// Magic Stick
namespace CompetitiveProgramming.CodeForces.MagicStick;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long x = numbers[0];
            long y = numbers[1];
            
            bool possible = true;
            if (x == 1) possible = y == 1;
            else if (x == 2 || x == 3) possible = y <= 3;
            
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
        StyleHelper.Title("Magic Stick");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}