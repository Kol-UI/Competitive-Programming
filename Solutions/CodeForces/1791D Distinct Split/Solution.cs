// Distinct Split
namespace CompetitiveProgramming.CodeForces.DistinctSplit;
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
    static public void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            
            HashSet<char> s = new HashSet<char>();
            int[] pre = new int[n];
            for (int i = 0; i < n; i++)
            {
                s.Add(str[i]);
                pre[i] = s.Count;
            }
            
            s.Clear();
            int[] suf = new int[n];
            for (int i = n - 1; i >= 0; i--)
            {
                s.Add(str[i]);
                suf[i] = s.Count;
            }
            
            int ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                ans = Math.Max(ans, pre[i] + suf[i + 1]);
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Distinct Split");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}