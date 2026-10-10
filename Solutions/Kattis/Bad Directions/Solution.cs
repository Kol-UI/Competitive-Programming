// Bad Directions
namespace CompetitiveProgramming.Kattis.BadDirections;
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
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            string nStr = input[1];
            char[] result = new char[nStr.Length];
            for (int j = 0; j < nStr.Length; j++)
            {
                result[j] = (char)('0' + (nStr[j] - '0' + k) % 10);
            }
            Console.WriteLine(new string(result));
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
        StyleHelper.Title("Bad Directions");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}