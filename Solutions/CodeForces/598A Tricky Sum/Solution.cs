// Tricky Sum
namespace CompetitiveProgramming.CodeForces.TrickySum;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine()!);
            long sum = n * (n + 1) / 2;
            long powerSum = 0;
            long powerOfTwo = 1;
            
            while (powerOfTwo <= n)
            {
                powerSum += powerOfTwo;
                powerOfTwo *= 2;
            }
            
            Console.WriteLine(sum - 2 * powerSum);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tricky Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}