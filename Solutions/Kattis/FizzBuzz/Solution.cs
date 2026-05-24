// FizzBuzz
namespace CompetitiveProgramming.Kattis.FizzBuzz;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int i = int.Parse(input[0]);
        int j = int.Parse(input[1]);
        int k = int.Parse(input[2]);
        
        for (int m = 1; m <= k; m++)
        {
            if (m % i == 0 && m % j == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (m % i == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (m % j == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(m);
            }
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("FizzBuzz");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}