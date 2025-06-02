// Contrast Value
namespace CompetitiveProgramming.CodeForces.ContrastValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> v = new List<int>();
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n; i++)
            {
                int x = nums[i];
                if (i == 0)
                {
                    v.Add(x);
                    continue;
                }
                if (v[v.Count - 1] != x)
                {
                    v.Add(x);
                }
            }
            int ans = v.Count;
            for (int i = 0; i + 2 < v.Count; i++)
            {
                if ((v[i] < v[i + 1] && v[i + 1] < v[i + 2]) || 
                    (v[i] > v[i + 1] && v[i + 1] > v[i + 2]))
                {
                    ans--;
                }
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
        StyleHelper.Title("Contrast Value");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}