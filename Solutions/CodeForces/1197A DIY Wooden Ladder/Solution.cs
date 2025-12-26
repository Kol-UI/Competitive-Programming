// DIY Wooden Ladder
namespace CompetitiveProgramming.CodeForces.DIYWoodenLadder;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long max1 = 0;
            long max2 = 0;
            
            foreach (long x in numbers)
            {
                if (x >= max1)
                {
                    max2 = max1;
                    max1 = x;
                }
                else if (x > max2)
                {
                    max2 = x;
                }
            }
            
            long answer = n - 2;
            answer = Math.Min(answer, max2 - 1);
            Console.WriteLine(answer);
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
        StyleHelper.Title("DIY Wooden Ladder");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}