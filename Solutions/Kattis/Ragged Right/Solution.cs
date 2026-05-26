// Ragged Right
namespace CompetitiveProgramming.Kattis.RaggedRight;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> v = new List<int>();
        string s;
        int m = 0;

        while ((s = Console.ReadLine()) != null)
        {
            int temp = s.Length;
            if (temp > m) m = temp;
            v.Add(temp);
        }

        int total = 0;
        for (int i = 0; i < v.Count - 1; i++)
        {
            int diff = m - v[i];
            total += diff * diff;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ragged Right");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}