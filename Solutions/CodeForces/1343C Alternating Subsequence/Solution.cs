// Alternating Subsequence
namespace CompetitiveProgramming.CodeForces.AlternatingSubsequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<long> v = new List<long>();
            long sum = 0;
            long x = 0;
            string[] input = Console.ReadLine()!.Split();
            for (int i = 0; i < n; i++)
            {
                long a = long.Parse(input[i]);
                if (a > 0)
                {
                    if (v.Count > 0)
                    {
                        sum += v.Max();
                        v.Clear();
                    }
                    if (a > x)
                    {
                        sum += a;
                        sum -= x;
                        x = a;
                    }
                }
                else
                {
                    x = 0;
                    v.Add(a);
                }
            }
            if (v.Count > 0)
            {
                sum += v.Max();
            }
            Console.WriteLine(sum);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alternating Subsequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.HardLC);
    }
}