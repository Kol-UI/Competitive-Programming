// Assembly via Minimums
namespace CompetitiveProgramming.CodeForces.AssemblyviaMinimums;
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
            int n = int.Parse(Console.ReadLine()!);
            SortedDictionary<int, int> mp = new SortedDictionary<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            int total = n * (n - 1) / 2;
            string[] input = Console.ReadLine()!.Split();
            for (int i = 0; i < total; i++)
            {
                int x = int.Parse(input[i]);
                if (mp.ContainsKey(x))
                    mp[x]++;
                else
                    mp[x] = 1;
            }
            int xVal = 0;
            foreach (var kvp in mp)
            {
                int count = kvp.Value;
                while (count > 0)
                {
                    Console.Write(kvp.Key + " ");
                    count -= xVal;
                    xVal++;
                }
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Assembly via Minimums");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}