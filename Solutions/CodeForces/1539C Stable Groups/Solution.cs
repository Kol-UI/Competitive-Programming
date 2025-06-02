// Stable Groups
namespace CompetitiveProgramming.CodeForces.StableGroups;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
        long n = input[0], k = input[1], x = input[2];
        List<long> v = Console.ReadLine().Split().Select(long.Parse).ToList();
        v.Sort();
        List<long> dis = new List<long>();
        for (int i = 1; i < n; i++)
        {
            long temp = v[i] - v[i - 1];
            if (temp > x)
                dis.Add(temp);
        }
        dis.Sort();
        int ans = 1;
        foreach (var i in dis)
        {
            long required = (i - 1) / x;
            if (k >= required)
                k -= required;
            else
                ans++;
        }
        Console.WriteLine(ans);
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
        StyleHelper.Title("Stable Groups");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}