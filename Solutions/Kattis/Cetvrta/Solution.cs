// Cetvrta
namespace CompetitiveProgramming.Kattis.Cetvrta;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        int a = 0;
        int b = 0;
        
        for (int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            
            a ^= x;
            b ^= y;
        }
        
        Console.WriteLine($"{a} {b}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cetvrta");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}