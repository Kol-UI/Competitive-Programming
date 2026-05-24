// Circuit Math
namespace CompetitiveProgramming.Kattis.CircuitMath;
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
        
        string[] inpStr = Console.ReadLine().Split();
        bool[] inp = new bool[n];
        for (int i = 0; i < n; i++)
        {
            inp[i] = inpStr[i] == "T";
        }
        
        string[] expr = Console.ReadLine().Split();
        Stack<bool> stack = new Stack<bool>();
        
        foreach (string c in expr)
        {
            if (c == "*")
            {
                bool a = stack.Pop();
                bool b = stack.Pop();
                stack.Push(a && b);
            }
            else if (c == "+")
            {
                bool a = stack.Pop();
                bool b = stack.Pop();
                stack.Push(a || b);
            }
            else if (c == "-")
            {
                bool a = stack.Pop();
                stack.Push(!a);
            }
            else
            {
                stack.Push(inp[c[0] - 'A']);
            }
        }
        
        Console.WriteLine(stack.Peek() ? "T" : "F");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Circuit Math");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}