// Number Fun
namespace CompetitiveProgramming.Kattis.NumberFun;
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
        int cases = int.Parse(Console.ReadLine());

        while (cases-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            bool possible = false;
            if (a + b == c) possible = true;
            if (a * b == c) possible = true;
            if (a - b == c) possible = true;
            if (b - a == c) possible = true;
            if (a % b == 0 && a / b == c) possible = true;
            if (b % a == 0 && b / a == c) possible = true;

            Console.WriteLine(possible ? "Possible" : "Impossible");
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
        StyleHelper.Title("Number Fun");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}