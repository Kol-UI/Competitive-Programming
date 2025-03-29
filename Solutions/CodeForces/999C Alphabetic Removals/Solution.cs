// Alphabetic Removals
namespace CompetitiveProgramming.CodeForces.AlphabeticRemovals;
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
        int k = int.Parse(input[1]);
        string str = Console.ReadLine()!;
        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in str)
        {
            if (count.ContainsKey(c)) count[c]++;
            else count[c] = 1;
        }

        for (char c = 'a'; c <= 'z' && k > 0; c++)
        {
            if (count.ContainsKey(c))
            {
                int remove = Math.Min(k, count[c]);
                count[c] -= remove;
                k -= remove;
            }
        }

        System.Text.StringBuilder result = new System.Text.StringBuilder();
        for (int i = n - 1; i >= 0; i--)
        {
            char c = str[i];
            if (count.ContainsKey(c) && count[c] > 0)
            {
                result.Append(c);
                count[c]--;
            }
        }

        char[] chars = result.ToString().ToCharArray();
        Array.Reverse(chars);
        Console.WriteLine(new string(chars));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alphabetic Removals");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}