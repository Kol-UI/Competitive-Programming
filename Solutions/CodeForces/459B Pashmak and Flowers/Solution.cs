// Pashmak and Flowers
namespace CompetitiveProgramming.CodeForces.PashmakandFlowers;

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
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
        
        Array.Sort(arr);
        
        long mn = arr.Count(x => x == arr[0]);
        long mx = arr.Count(x => x == arr[n - 1]);
        long way;
        
        if (n == 2)
            way = 1;
        else if (arr[0] == arr[n - 1])
            way = (mx * (mx - 1)) / 2;
        else
            way = mx * mn;
        
        Console.WriteLine($"{arr[n - 1] - arr[0]} {way}");
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
        StyleHelper.Title("Pashmak and Flowers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
	}
}