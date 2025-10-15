// Fast Food Restaurant
namespace CompetitiveProgramming.CodeForces.FastFoodRestaurant;
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
            long[] gifts = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(gifts);
            Array.Reverse(gifts);
            
            long a = gifts[0];
            long b = gifts[1];
            long c = gifts[2];
            
            long giftCount = 0;
            
            if (a > 0) { a--; giftCount++; }
            if (b > 0) { b--; giftCount++; }
            if (c > 0) { c--; giftCount++; }
            
            if (a > 0 && b > 0) { a--; b--; giftCount++; }
            if (a > 0 && c > 0) { a--; c--; giftCount++; }
            if (b > 0 && c > 0) { b--; c--; giftCount++; }
            
            if (a > 0 && b > 0 && c > 0) { giftCount++; }
            
            Console.WriteLine(giftCount);
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
        StyleHelper.Title("Fast Food Restaurant");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}