// Bear and Raspberry
namespace CompetitiveProgramming.CodeForces.BearandRaspberry;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int c = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split();
        int[] price = new int[n];
        for (int k = 0; k < n; k++)
        {
            price[k] = int.Parse(secondLine[k]);
        }
        
        int maxDecrease = 0;
        for (int k = 1; k < n; k++)
        {
            int decrease = price[k - 1] - price[k];
            if (decrease > maxDecrease)
            {
                maxDecrease = decrease;
            }
        }
        
        if (maxDecrease > c)
        {
            Console.WriteLine(maxDecrease - c);
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bear and Raspberry");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}