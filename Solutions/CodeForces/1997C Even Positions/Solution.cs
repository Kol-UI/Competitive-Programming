// Even Positions
namespace CompetitiveProgramming.CodeForces.EvenPositions;
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
        int testCases = int.Parse(Console.ReadLine());
        
        for (int test = 0; test < testCases; test++)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            Stack<int> stack = new Stack<int>();
            long cost = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    cost += i - stack.Pop();
                }
                else if (stack.Count == 0)
                {
                    stack.Push(i);
                }
                else
                {
                    cost += i - stack.Pop();
                }
            }
            
            Console.WriteLine(cost);
        }
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
        StyleHelper.Title("Even Positions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}