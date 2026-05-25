// Next Test
namespace CompetitiveProgramming.CodeForces.NextTest;
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
        const int maxN = 3002;
        bool[] tests = new bool[maxN];

        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        
        for (int k = 0; k < n; k++)
        {
            int temp = int.Parse(input[k]);
            tests[temp] = true;
        }

        for (int index = 1; index < maxN; index++)
        {
            if (!tests[index])
            {
                Console.WriteLine(index);
                break;
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
        StyleHelper.Title("Next Test");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}