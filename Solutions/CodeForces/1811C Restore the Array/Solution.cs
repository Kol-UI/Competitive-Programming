// Restore the Array
namespace CompetitiveProgramming.CodeForces.RestoretheArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            List<int> ans = new List<int> { v[0] };

            for (int i = 1; i < n - 1; i++)
            {
                ans.Add(Math.Min(v[i], v[i - 1]));
            }
            
            ans.Add(v[^1]);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Restore the Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}