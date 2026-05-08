// Transformation: from A to B
namespace CompetitiveProgramming.CodeForces.TransformationfromAtoB;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static void Dfs(List<long> v, long target, ref bool possible)
    {
        if (v.Count == 0 || possible || v[v.Count - 1] > target) return;
        if (v[v.Count - 1] == target)
        {
            possible = true;
            return;
        }

        long x = v[v.Count - 1];
        v.Add(2 * x);
        Dfs(v, target, ref possible);
        if (possible) return;
        v.RemoveAt(v.Count - 1);

        v.Add(10 * x + 1);
        Dfs(v, target, ref possible);
        if (possible) return;
        v.RemoveAt(v.Count - 1);
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        long a = long.Parse(input[0]);
        long b = long.Parse(input[1]);

        bool possible = false;
        List<long> steps = new List<long> { a };
        Dfs(steps, b, ref possible);

        if (possible)
        {
            Console.WriteLine("YES");
            Console.WriteLine(steps.Count);
            for (int p = 0; p < steps.Count; p++)
            {
                Console.Write($"{steps[p]} ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Transformation: from A to B");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}