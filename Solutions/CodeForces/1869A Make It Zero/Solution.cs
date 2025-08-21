// Make It Zero
namespace CompetitiveProgramming.CodeForces.MakeItZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = Convert.ToInt64(Console.ReadLine());
        while (t-- > 0)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            if (n % 2 != 0)
            {
                Console.WriteLine("4");
                Console.WriteLine($"2 {n}");
                Console.WriteLine($"2 {n}");
                Console.WriteLine("1 2");
                Console.WriteLine("1 2");
            }
            else
            {
                Console.WriteLine("2");
                Console.WriteLine($"1 {n}");
                Console.WriteLine($"1 {n}");
            }
        }
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
        StyleHelper.Title("Make It Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}