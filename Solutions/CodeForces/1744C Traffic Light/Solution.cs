// Traffic Light
namespace CompetitiveProgramming.CodeForces.TrafficLight;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            char c = input[1][0];
            string s = Console.ReadLine();

            if (c == 'g')
            {
                Console.WriteLine(0);
                continue;
            }

            int nxt = 0;
            for (int p = 0; p < s.Length && nxt == 0; p++)
            {
                if (s[p] == 'g') nxt = n + p;
            }

            int res = 0;
            for (int p = n - 1; p >= 0; p--)
            {
                if (s[p] == 'g') nxt = p;
                else if (s[p] == c)
                {
                    int cur = nxt - p;
                    res = Math.Max(res, cur);
                }
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Traffic Light");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}