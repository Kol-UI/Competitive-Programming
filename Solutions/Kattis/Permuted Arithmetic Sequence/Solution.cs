// Permuted Arithmetic Sequence
namespace CompetitiveProgramming.Kattis.PermutedArithmeticSequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool IsArithmetic(List<int> v)
    {
        int diff = v[0] - v[1];
        for (int i = 0; i < v.Count - 1; i++)
        {
            if (v[i] - v[i + 1] != diff)
                return false;
        }
        return true;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);

            List<int> seq = new List<int>();
            for (int j = 1; j <= m; j++)
            {
                seq.Add(int.Parse(input[j]));
            }

            if (IsArithmetic(seq))
            {
                Console.WriteLine("arithmetic");
                continue;
            }

            seq.Sort();

            if (IsArithmetic(seq))
            {
                Console.WriteLine("permuted arithmetic");
                continue;
            }

            Console.WriteLine("non-arithmetic");
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
        StyleHelper.Title("Permuted Arithmetic Sequence");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}