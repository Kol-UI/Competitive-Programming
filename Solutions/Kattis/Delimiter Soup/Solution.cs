// Delimiter Soup
namespace CompetitiveProgramming.Kattis.DelimiterSoup;
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
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> match = new Dictionary<char, char>
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == ' ') continue;

            if (match.ContainsKey(c))
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count > 0 && match[stack.Peek()] == c)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine($"{c} {i}");
                return;
            }
        }

        Console.WriteLine("ok so far");
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
        StyleHelper.Title("Delimiter Soup");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}