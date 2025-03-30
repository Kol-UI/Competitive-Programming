// Ahahahahahahahaha
namespace CompetitiveProgramming.CodeForces.Ahahahahahahahaha;
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
            var v = Console.ReadLine()!.Split().Select(int.Parse).ToList();
            int one = v.Count(x => x == 1);
            int zero = v.Count(x => x == 0);
            int x = zero >= one ? 0 : 1;
            int cnt = 0;
            var ans = new List<int>();
            
            for (int i = 0; i < n; i++)
            {
                if (v[i] == x)
                {
                    ans.Add(x);
                    cnt++;
                }
                if (cnt >= n / 2)
                {
                    if (x == 1)
                    {
                        if (ans.Count % 2 == 0) break;
                    }
                    else break;
                }
            }
            
            Console.WriteLine(ans.Count);
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ahahahahahahahaha");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}