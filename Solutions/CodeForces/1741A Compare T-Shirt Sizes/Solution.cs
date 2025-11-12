// Compare T-Shirt Sizes
namespace CompetitiveProgramming.CodeForces.CompareTShirtSizes;
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
            string[] input = Console.ReadLine().Split();
            string a = input[0];
            string b = input[1];
            
            char aLast = a[^1];
            char bLast = b[^1];
            
            if (aLast == bLast)
            {
                if (a.Length == b.Length)
                {
                    Console.WriteLine("=");
                }
                else if (aLast == 'S')
                {
                    Console.WriteLine(a.Length > b.Length ? "<" : ">");
                }
                else
                {
                    Console.WriteLine(a.Length > b.Length ? ">" : "<");
                }
            }
            else
            {
                if (aLast == 'L')
                {
                    Console.WriteLine(">");
                }
                else if (bLast == 'L')
                {
                    Console.WriteLine("<");
                }
                else if (aLast == 'M')
                {
                    Console.WriteLine(">");
                }
                else
                {
                    Console.WriteLine("<");
                }
            }
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
        StyleHelper.Title("Compare T-Shirt Sizes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}