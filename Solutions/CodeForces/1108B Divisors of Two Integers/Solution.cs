// Divisors of Two Integers
namespace CompetitiveProgramming.CodeForces.DivisorsofTwoIntegers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        Array.Sort(numbers);
        HashSet<long> divisors = new HashSet<long>();
        long max = numbers[numbers.Length - 1];
        long second = 0;
        
        for (int i = 0; i < n; i++)
        {
            if (max % numbers[i] == 0 && !divisors.Contains(numbers[i]))
            {
                divisors.Add(numbers[i]);
            }
            else
            {
                second = numbers[i];
            }
        }
        
        Console.WriteLine($"{max} {second}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divisors of Two Integers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}