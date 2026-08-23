// Tautology
namespace CompetitiveProgramming.Kattis.Tautology;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static bool Check(string s, Dictionary<char, int> vals)
    {
        Stack<int> stk = new Stack<int>();

        for (int idx = s.Length - 1; idx >= 0; idx--)
        {
            char op = s[idx];

            if (op >= 'p' && op <= 't')
            {
                stk.Push(vals[op]);
            }
            else if (op == 'N')
            {
                int a = stk.Pop();
                stk.Push(1 - a);
            }
            else if (op == 'K')
            {
                int a = stk.Pop();
                int b = stk.Pop();
                stk.Push(a & b);
            }
            else if (op == 'A')
            {
                int a = stk.Pop();
                int b = stk.Pop();
                stk.Push(a | b);
            }
            else if (op == 'C')
            {
                int a = stk.Pop();
                int b = stk.Pop();
                stk.Push((a == 1 && b == 0) ? 0 : 1);
            }
            else if (op == 'E')
            {
                int a = stk.Pop();
                int b = stk.Pop();
                stk.Push(a == b ? 1 : 0);
            }
        }

        return stk.Pop() == 1;
    }

    static void Main()
    {
        while (true)
        {
            string s = Console.ReadLine();
            if (s == "0") break;

            bool isTautology = true;

            for (int mask = 0; mask < 32; mask++)
            {
                Dictionary<char, int> vals = new Dictionary<char, int>();
                char[] vars = { 'p', 'q', 'r', 's', 't' };

                for (int i = 0; i < 5; i++)
                {
                    vals[vars[i]] = (mask & (1 << i)) != 0 ? 1 : 0;
                }

                if (!Check(s, vals))
                {
                    isTautology = false;
                    break;
                }
            }

            Console.WriteLine(isTautology ? "tautology" : "not");
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
        StyleHelper.Title("Tautology");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}