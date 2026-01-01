// Holidays
namespace CompetitiveProgramming.CodeForces.Holidays;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static (int minimum, int maximum) CalculateRestDays(int totalDays)
    {
        int fullWeeks = totalDays / 7;
        int remainingDays = totalDays % 7;
        
        int minimumRestDays = 2 * fullWeeks + (remainingDays == 6 ? 1 : 0);
        int maximumRestDays = 2 * fullWeeks + 
                            (remainingDays > 0 ? 1 : 0) + 
                            (remainingDays > 1 ? 1 : 0);
        
        return (minimumRestDays, maximumRestDays);
    }

    static void Main()
    {
        int totalDays = int.Parse(Console.ReadLine());
        var (minimumRestDays, maximumRestDays) = CalculateRestDays(totalDays);
        Console.WriteLine($"{minimumRestDays} {maximumRestDays}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Holidays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}