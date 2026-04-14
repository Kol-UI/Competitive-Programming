// Nasty Hacks
namespace CompetitiveProgramming.Kattis.NastyHacks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            long r = long.Parse(input[0]);
            long e = long.Parse(input[1]);
            long c = long.Parse(input[2]);
            
            if (e - c == r)
            {
                Console.WriteLine("does not matter");
            }
            else if (e - c > r)
            {
                Console.WriteLine("advertise");
            }
            else
            {
                Console.WriteLine("do not advertise");
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
        StyleHelper.Title("Nasty Hacks");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}