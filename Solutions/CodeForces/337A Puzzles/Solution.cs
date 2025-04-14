// Puzzles
namespace CompetitiveProgramming.CodeForces.Puzzles;
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
        int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        int n = input[0], m = input[1];
        int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
        Array.Sort(arr);
        int ans = arr[n-1] - arr[0];
        for(int i = 0; i <= m - n; i++)
            ans = Math.Min(ans, arr[i + n - 1] - arr[i]);
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Puzzles");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}