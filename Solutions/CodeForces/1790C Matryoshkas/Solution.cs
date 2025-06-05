// Matryoshkas
namespace CompetitiveProgramming.CodeForces.MatryoshkasC;
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
            Dictionary<int, int> freq = new Dictionary<int, int>();
            
            foreach (int num in v)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            int ans = 0;
            foreach (var num in freq.Keys.OrderBy(x => x))
            {
                int current = freq[num];
                if (freq.ContainsKey(num - 1))
                {
                    int prev = freq[num - 1];
                    if (current > prev)
                        ans += current - prev;
                }
                else
                {
                    ans += current;
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