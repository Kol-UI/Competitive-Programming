// Heliocentric
namespace CompetitiveProgramming.Kattis.Heliocentric;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = 1;
        string line;
        
        while ((line = Console.ReadLine()) != null)
        {
            string[] input = line.Split();
            if (input.Length < 2) break;
            
            int earth = int.Parse(input[0]);
            int mars = int.Parse(input[1]);
            
            Console.Write($"Case {n}: ");
            
            int days = 0;
            while (earth != 0 || mars != 0)
            {
                days++;
                earth = (earth + 1) % 365;
                mars = (mars + 1) % 687;
            }
            
            Console.WriteLine(days);
            n++;
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Heliocentric");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}