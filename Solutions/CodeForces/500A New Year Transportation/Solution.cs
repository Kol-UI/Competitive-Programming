// New Year Transportation
namespace CompetitiveProgramming.CodeForces.NewYearTransportation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int t = int.Parse(input[1]);
        
        int[] v = new int[n + 1];
        string[] values = Console.ReadLine().Split();
        for (int i = 1; i < n; i++)
        {
            v[i] = int.Parse(values[i - 1]);
        }
        
        bool ok = false;
        for (int i = 1; i < n && i <= t;)
        {
            ok |= (i == t);
            i += v[i];
            ok |= (i == t);
        }
        
        Console.WriteLine(ok ? "YES" : "NO");
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
        StyleHelper.Title("New Year Transportation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}