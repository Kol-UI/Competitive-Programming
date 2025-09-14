// Wet Shark and Odd and Even
namespace CompetitiveProgramming.CodeForces.WetSharkandOddandEven;
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
        long n = long.Parse(Console.ReadLine());
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        long total = 0, smallestOdd = 0;
        foreach (long x in numbers)
        {
            total += x;
            if (x % 2 != 0 && (smallestOdd == 0 || x < smallestOdd)) 
                smallestOdd = x;
        }
        
        if (total % 2 != 0) 
            total -= smallestOdd;
            
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Wet Shark and Odd and Even");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}