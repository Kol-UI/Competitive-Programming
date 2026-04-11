// Pet
namespace CompetitiveProgramming.Kattis.Pet;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        int[,] scores = new int[5, 4];

        for (int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Split();
            for (int j = 0; j < 4; j++)
            {
                scores[i, j] = int.Parse(input[j]);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 1; j < 4; j++)
            {
                scores[i, 0] += scores[i, j];
            }
        }

        int max = -1;
        int loc = -1;
        for (int i = 0; i < 5; i++)
        {
            if (scores[i, 0] > max)
            {
                max = scores[i, 0];
                loc = i;
            }
        }
        
        Console.WriteLine($"{loc + 1} {max}");
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pet");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}