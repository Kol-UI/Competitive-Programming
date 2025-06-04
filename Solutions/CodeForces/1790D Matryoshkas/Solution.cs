// Matryoshkas
namespace CompetitiveProgramming.CodeForces.Matryoshkas;
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
            int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(v);
            Dictionary<int, int> mp = new Dictionary<int, int>();
            int ans = 0;
            foreach (int num in v)
            {
                if (mp.ContainsKey(num - 1) && mp[num - 1] > 0)
                {
                    mp[num - 1]--;
                }
                else
                {
                    ans++;
                }
                if (mp.ContainsKey(num))
                {
                    mp[num]++;
                }
                else
                {
                    mp[num] = 1;
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
        StyleHelper.Title("Matryoshkas");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}