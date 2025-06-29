// Doremy's Paint 3
namespace CompetitiveProgramming.CodeForces.DoremysPaint3;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> mp = new Dictionary<int, int>();
            string[] nums = Console.ReadLine().Split();
            
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(nums[i]);
                if (mp.ContainsKey(x))
                    mp[x]++;
                else
                    mp[x] = 1;
            }

            bool ok = true;
            if (mp.Count <= 2)
            {
                foreach (var kvp in mp)
                {
                    ok &= (kvp.Value >= n / 2);
                }
            }
            else
            {
                ok = false;
            }

            Console.WriteLine(ok ? "YES" : "NO");
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
        StyleHelper.Title("Doremy's Paint 3");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
	}
}