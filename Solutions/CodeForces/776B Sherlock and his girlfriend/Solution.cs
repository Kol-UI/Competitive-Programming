// Sherlock and his girlfriend
namespace CompetitiveProgramming.CodeForces.Sherlockandhisgirlfriend;
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
        bool[] prime = new bool[100000 + 10];

        for (int i = 2; i * i <= n + 1; i++)
        {
            for (int j = i * i; j <= n + 1; j += i)
            {
                prime[j] = true;
            }
        }

        List<int> ans = new List<int>();
        HashSet<int> s = new HashSet<int>();

        for (int i = 2; n > 0; i++)
        {
            if (prime[i])
            {
                ans.Add(2);
                s.Add(2);
            }
            else
            {
                ans.Add(1);
                s.Add(1);
            }
            n--;
        }

        Console.WriteLine(s.Count);
        Console.WriteLine(string.Join(" ", ans));
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sherlock and his girlfriend");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}