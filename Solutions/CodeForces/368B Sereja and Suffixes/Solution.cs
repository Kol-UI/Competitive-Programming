// Sereja and Suffixes
namespace CompetitiveProgramming.CodeForces.SerejaandSuffixes;
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
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        bool[] v = new bool[100010];
        for (int i = 0; i < n; i++)
        {
            v[arr[i]] = true;
        }

        Array.Reverse(arr);
        int[] psum = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            if (v[arr[i - 1]])
            {
                psum[i] = psum[i - 1] + 1;
                v[arr[i - 1]] = false;
            }
            else
            {
                psum[i] = psum[i - 1];
            }
        }

        for (int i = 0; i < m; i++)
        {
            int l = int.Parse(Console.ReadLine()!);
            Console.WriteLine(psum[n - l + 1]);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sereja and Suffixes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}