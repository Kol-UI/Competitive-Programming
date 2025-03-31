// Yet Another Permutation Problem

namespace CompetitiveProgramming.CodeForces.YetAnotherPermutationProblem;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            bool[] vis = new bool[n + 5];
            
            for (int i = 1; i <= n; i++)
            {
                long x = i;
                while (true)
                {
                    if (!vis[x])
                    {
                        Console.Write(x + " ");
                    }
                    vis[x] = true;
                    x *= 2;
                    if (x > n) break;
                }
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Yet Another Permutation Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}