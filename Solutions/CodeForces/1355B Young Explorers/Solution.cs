// Young Explorers
namespace CompetitiveProgramming.CodeForces.YoungExplorers;
using CompetitiveProgramming;
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
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int num in numbers)
            {
                if (mp.ContainsKey(num))
                    mp[num]++;
                else
                    mp[num] = 1;
            }

            int ans = 0;
            int temp = 0;
            foreach (var kvp in mp.OrderBy(x => x.Key))
            {
                int count = kvp.Value + temp;
                ans += count / kvp.Key;
                temp = count % kvp.Key;
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
        StyleHelper.Title("Young Explorers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}