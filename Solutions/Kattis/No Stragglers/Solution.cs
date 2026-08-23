// No Stragglers
namespace CompetitiveProgramming.Kattis.NoStragglers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine()!);
        int sum = 0;

        for (int i = 0; i < count; i++)
        {
            string[] line = Console.ReadLine()!.Split();
            string action = line[1];
            int value = int.Parse(line[2]);

            if (action == "IN")
            {
                sum += value;
            }
            else
            {
                sum -= value;
            }
        }

        Console.WriteLine(sum == 0 ? "NO STRAGGLERS" : sum);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("No Stragglers");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}