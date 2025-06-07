// Corrupted Array
namespace CompetitiveProgramming.CodeForces.CorruptedArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Solve()
    {
        int n = int.Parse(Console.ReadLine());
        long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
        Array.Sort(v);
        long sum = v.Take(n).Sum();

        if (sum == v[n] || sum == v[n + 1])
        {
            Console.WriteLine(string.Join(" ", v.Take(n)));
            return;
        }

        sum += v[n];
        for (int i = 0; i < n + 1; i++)
        {
            sum -= v[i];
            if (sum == v[n + 1])
            {
                Console.WriteLine(string.Join(" ", v.Where((val, idx) => idx != i && idx != n + 1)));
                return;
            }
            sum += v[i];
        }
        Console.WriteLine(-1);
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            Solve();
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
        StyleHelper.Title("Corrupted Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}