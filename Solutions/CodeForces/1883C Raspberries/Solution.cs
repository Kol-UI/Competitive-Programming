// Raspberries
namespace CompetitiveProgramming.CodeForces.Raspberries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], k = input[1];
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int evens = a.Count(x => x % 2 == 0);
            int minDiff = int.MaxValue;
            
            foreach (int num in a)
            {
                int diff = ((num + k - 1) / k) * k - num;
                if (diff < minDiff)
                    minDiff = diff;
            }
            
            if (k == 4)
            {
                if (evens >= 2)
                    minDiff = 0;
                else if (evens == 1)
                    minDiff = Math.Min(minDiff, 1);
                else
                    minDiff = Math.Min(minDiff, 2);
            }
            
            Console.WriteLine(minDiff);
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
        StyleHelper.Title("Raspberries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}