// Forgetting Things
namespace CompetitiveProgramming.CodeForces.ForgettingThings;
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
        string[] input = Console.ReadLine().Split();
        int da = int.Parse(input[0]);
        int db = int.Parse(input[1]);
        
        if (da == 9 && db == 1)
        {
            Console.WriteLine("9 10");
        }
        else if (da == db)
        {
            Console.WriteLine($"{10 * da} {10 * da + 1}");
        }
        else if (db == da + 1)
        {
            Console.WriteLine($"{10 * da + 9} {10 * (da + 1)}");
        }
        else
        {
            Console.WriteLine("-1");
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
        StyleHelper.Title("Forgetting Things");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}