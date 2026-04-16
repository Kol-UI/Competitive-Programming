namespace CompetitiveProgramming.Kattis.ASCIIAddition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static Dictionary<char, string[]> ascii = new Dictionary<char, string[]>
    {
        { '0', new string[] { "xxxxx", "x...x", "x...x", "x...x", "x...x", "x...x", "xxxxx" } },
        { '1', new string[] { "....x", "....x", "....x", "....x", "....x", "....x", "....x" } },
        { '2', new string[] { "xxxxx", "....x", "....x", "xxxxx", "x....", "x....", "xxxxx" } },
        { '3', new string[] { "xxxxx", "....x", "....x", "xxxxx", "....x", "....x", "xxxxx" } },
        { '4', new string[] { "x...x", "x...x", "x...x", "xxxxx", "....x", "....x", "....x" } },
        { '5', new string[] { "xxxxx", "x....", "x....", "xxxxx", "....x", "....x", "xxxxx" } },
        { '6', new string[] { "xxxxx", "x....", "x....", "xxxxx", "x...x", "x...x", "xxxxx" } },
        { '7', new string[] { "xxxxx", "....x", "....x", "....x", "....x", "....x", "....x" } },
        { '8', new string[] { "xxxxx", "x...x", "x...x", "xxxxx", "x...x", "x...x", "xxxxx" } },
        { '9', new string[] { "xxxxx", "x...x", "x...x", "xxxxx", "....x", "....x", "xxxxx" } },
        { '+', new string[] { ".....", "..x..", "..x..", "xxxxx", "..x..", "..x..", "....." } }
    };

    static char FromAscii(string[] lines)
    {
        foreach (var kvp in ascii)
        {
            if (kvp.Value.SequenceEqual(lines))
                return kvp.Key;
        }
        return '?';
    }

    static void Main()
    {
        string[] inp = new string[7];
        for (int i = 0; i < 7; i++)
        {
            inp[i] = Console.ReadLine()!;
        }

        List<char> toks = new List<char>();
        for (int i = 0; i < inp[0].Length; i += 6)
        {
            string[] curr = new string[7];
            for (int j = 0; j < 7; j++)
            {
                curr[j] = inp[j].Substring(i, 5);
            }
            toks.Add(FromAscii(curr));
        }

        string expression = new string(toks.ToArray());
        int result = EvaluateExpression(expression);
        string res = result.ToString();

        List<List<string>> outLines = new List<List<string>>();
        for (int i = 0; i < 7; i++)
        {
            outLines.Add(new List<string>());
        }

        foreach (char c in res)
        {
            string[] lines = ascii[c];
            for (int i = 0; i < 7; i++)
            {
                outLines[i].Add(lines[i]);
            }
        }

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(string.Join(".", outLines[i]));
        }
    }

    static int EvaluateExpression(string expr)
    {
        var parts = expr.Split('+');
        int sum = 0;
        foreach (var part in parts)
        {
            sum += int.Parse(part);
        }
        return sum;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("ASCII Addition");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}