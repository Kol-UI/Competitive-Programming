// Boats Competition
namespace CompetitiveProgramming.CodeForces.BoatsCompetition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
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
            int[] v = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Array.Sort(v);
            int mx = 0;
            for (int s = 100; s > 0; s--)
            {
                int l = 0, r = n - 1;
                int cnt = 0;
                while (l < r)
                {
                    if (v[l] + v[r] == s)
                    {
                        cnt++;
                        l++;
                        r--;
                        mx = Math.Max(mx, cnt);
                    }
                    else if (v[l] + v[r] < s)
                    {
                        l++;
                    }
                    else
                    {
                        r--;
                    }
                }
            }
            Console.WriteLine(mx);
        }
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Boats Competition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}