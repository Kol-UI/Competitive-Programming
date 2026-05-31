// Permutation Encryption
namespace CompetitiveProgramming.Kattis.PermutationEncryption;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] parts = line.Split();
            int n = int.Parse(parts[0]);
            if (n == 0) break;

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(parts[i + 1]) - 1;

            string s = Console.ReadLine();
            List<char> sList = new List<char>(s);

            while (sList.Count % n != 0)
                sList.Add(' ');

            char[] ans = new char[sList.Count];

            for (int i = 0; i < sList.Count; i++)
            {
                int k = i / n;
                int idx = k * n + a[i % n];
                ans[i] = sList[idx];
            }

            Console.WriteLine($"'{new string(ans)}'");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Permutation Encryption");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}