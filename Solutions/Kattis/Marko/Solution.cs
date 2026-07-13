// Marko
namespace CompetitiveProgramming.Kattis.Marko;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<char, char> c = new Dictionary<char, char>
        {
            { 'a', '2' }, { 'b', '2' }, { 'c', '2' },
            { 'd', '3' }, { 'e', '3' }, { 'f', '3' },
            { 'g', '4' }, { 'h', '4' }, { 'i', '4' },
            { 'j', '5' }, { 'k', '5' }, { 'l', '5' },
            { 'm', '6' }, { 'n', '6' }, { 'o', '6' },
            { 'p', '7' }, { 'q', '7' }, { 'r', '7' }, { 's', '7' },
            { 't', '8' }, { 'u', '8' }, { 'v', '8' },
            { 'w', '9' }, { 'x', '9' }, { 'y', '9' }, { 'z', '9' }
        };

        int n = int.Parse(Console.ReadLine());
        List<string> v = new List<string>();

        for (int i = 0; i < n; i++)
        {
            v.Add(Console.ReadLine());
        }

        string numbers = Console.ReadLine();

        int possible = 0;
        foreach (string word in v)
        {
            if (numbers.Length != word.Length) continue;

            bool same = true;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != c[word[i]])
                {
                    same = false;
                    break;
                }
            }

            if (same) possible++;
        }

        Console.WriteLine(possible);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Marko");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}