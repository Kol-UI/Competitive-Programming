// Same Differences
namespace CompetitiveProgramming.CodeForces.SameDifferences;
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
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine()!);
            Dictionary<long, long> mp = new Dictionary<long, long>();
            long ans = 0;
            string[] input = Console.ReadLine()!.Split();
            for (long i = 0; i < n; i++)
            {
                long a = long.Parse(input[i]);
                long key = a - i;
                if (mp.ContainsKey(key))
                {
                    ans += mp[key];
                    mp[key]++;
                }
                else
                {
                    mp[key] = 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Same Differences");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}