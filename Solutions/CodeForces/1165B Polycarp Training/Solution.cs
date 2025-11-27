// Polycarp Training
namespace CompetitiveProgramming.CodeForces.PolycarpTraining;
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
        int n = int.Parse(Console.ReadLine());
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        Array.Sort(numbers);
        long count = 0;
        
        foreach (long number in numbers)
        {
            if (number >= count + 1)
            {
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Polycarp Training");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}