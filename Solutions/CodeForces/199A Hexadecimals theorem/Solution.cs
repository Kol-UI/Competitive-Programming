// Hexadecimal's theorem
namespace CompetitiveProgramming.CodeForces.Hexadecimalstheorem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long input = long.Parse(Console.ReadLine());
        long first = 0;
        long second = 0;
        long temp = 0;
        long newFib = 1;
        
        while (newFib < input)
        {
            first = second;
            temp = newFib;
            newFib += second;
            second = temp;
        }
        
        if (input == 1)
        {
            second = 1;
        }
        
        Console.WriteLine($"{second - first} {first} {first}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hexadecimal's theorem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}