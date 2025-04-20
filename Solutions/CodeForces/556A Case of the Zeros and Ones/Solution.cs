// Case of the Zeros and Ones
namespace CompetitiveProgramming.CodeForces.CaseoftheZerosandOnes;
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
        int n = int.Parse(Console.ReadLine()!);
        string str = Console.ReadLine()!;
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < n; i++)
        {
            if (stack.Count > 0)
            {
                int a = stack.Peek() - '0';
                int b = str[i] - '0';
                if (b == (a ^ 1))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(str[i]);
                }
            }
            else
            {
                stack.Push(str[i]);
            }
        }

        Console.WriteLine(stack.Count);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Case of the Zeros and Ones");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}