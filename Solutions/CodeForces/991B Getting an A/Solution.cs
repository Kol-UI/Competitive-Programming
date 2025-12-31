// Getting an A
namespace CompetitiveProgramming.CodeForces.GettinganA;
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
        int n = int.Parse(Console.ReadLine());
        int[] ratings = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int required = (int)Math.Ceiling(4.5 * n);
        int[] count = new int[6];
        int sum = 0;
        
        foreach (int rating in ratings)
        {
            count[rating]++;
            sum += rating;
        }
        
        int needed = required - sum;
        int index = 2;
        int changes = 0;
        
        while (needed > 0)
        {
            if (count[index] > 0)
            {
                count[index]--;
                needed -= (5 - index);
                changes++;
            }
            else
            {
                index++;
            }
        }
        
        Console.WriteLine(changes);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Getting an A");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}