// Mocha and Math
namespace CompetitiveProgramming.CodeForces.MochaandMath;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<int> v = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

            int ans = v[0];
            for (int i = 0; i < n; i++)
            {
                ans &= v[i];
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sereja and Dima");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}