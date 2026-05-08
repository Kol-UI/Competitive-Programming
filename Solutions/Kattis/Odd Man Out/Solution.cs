// Odd Man Out
namespace CompetitiveProgramming.Kattis.OddManOut;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int items = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            List<long> v = new List<long>();

            Console.Write($"Case #{i + 1}: ");

            for (int j = 0; j < items; j++)
            {
                v.Add(long.Parse(input[j]));
            }

            v.Sort();

            bool printed = false;
            for (int k = 0; k < v.Count - 1; k += 2)
            {
                if (v[k] != v[k + 1] && !printed)
                {
                    Console.WriteLine(v[k]);
                    printed = true;
                }
            }
            if (!printed)
            {
                Console.WriteLine(v[items - 1]);
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
        StyleHelper.Title("Odd Man Out");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}