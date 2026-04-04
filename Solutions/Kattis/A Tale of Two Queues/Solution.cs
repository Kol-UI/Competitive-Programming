// A Tale of Two Queues
namespace CompetitiveProgramming.Kattis.ATaleofTwoQueues;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        Console.ReadLine();
        
        int sum1 = Console.ReadLine().Split().Select(int.Parse).Sum();
        int sum2 = Console.ReadLine().Split().Select(int.Parse).Sum();
        
        if(sum1 == sum2)
        {
            Console.WriteLine("either");
        }
        else if(sum1 < sum2)
        {
            Console.WriteLine("left");
        }
        else
        {
            Console.WriteLine("right");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("A Tale of Two Queues");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}