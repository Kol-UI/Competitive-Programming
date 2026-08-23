// Smallest Calculated Value
namespace CompetitiveProgramming.Kattis.SmallestCalculatedValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        int ans = 1000000000;
        char[] ops = { '+', '-', '*', '/' };

        foreach (char op1 in ops)
        {
            foreach (char op2 in ops)
            {
                int v = a;

                if (op1 == '/' && a % b != 0)
                    continue;

                switch (op1)
                {
                    case '+': v += b; break;
                    case '-': v -= b; break;
                    case '*': v *= b; break;
                    case '/': v /= b; break;
                }

                if (op2 == '/' && v % c != 0)
                    continue;

                switch (op2)
                {
                    case '+': v += c; break;
                    case '-': v -= c; break;
                    case '*': v *= c; break;
                    case '/': v /= c; break;
                }

                if (v < 0)
                    continue;

                if (v < ans)
                    ans = v;
            }
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Calculated Value");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}