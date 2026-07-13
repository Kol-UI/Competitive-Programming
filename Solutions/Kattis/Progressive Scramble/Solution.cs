// Progressive Scramble
namespace CompetitiveProgramming.Kattis.ProgressiveScramble;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static int GetVal(char c)
    {
        if (c == ' ') return 0;
        return c - 'a' + 1;
    }

    static char GetChr(int v)
    {
        if (v == 0) return ' ';
        return (char)('a' + v - 1);
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        for (int idx = 0; idx < t; idx++)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, 2);
            char type = input[0][0];
            string msg = input.Length > 1 ? input[1] : "";

            List<char> ans = new List<char>();
            ans.Add(msg[0]);

            int sm = (type == 'e') ? GetVal(msg[0]) : 0;

            for (int i = 1; i < msg.Length; i++)
            {
                char curr = (type == 'e') ? msg[i] : ans[i - 1];
                sm += GetVal(curr);
                sm %= 27;

                if (type == 'e')
                {
                    ans.Add(GetChr(sm));
                }
                else
                {
                    int val = (GetVal(msg[i]) - sm) % 27;
                    if (val < 0) val += 27;
                    ans.Add(GetChr(val));
                }
            }

            Console.WriteLine(new string(ans.ToArray()));
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
        StyleHelper.Title("Progressive Scramble");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}