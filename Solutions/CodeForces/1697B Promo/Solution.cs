// Promo
namespace CompetitiveProgramming.CodeForces.Promo;
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
        string[] input = Console.ReadLine()!.Split();
        long n = long.Parse(input[0]);
        long q = long.Parse(input[1]);
        long[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        Array.Sort(arr);
        Array.Reverse(arr);

        long[] prefixSum = new long[n + 1];
        for (int i = 0; i < n; i++)
            prefixSum[i + 1] = prefixSum[i] + arr[i];

        while (q-- > 0)
        {
            input = Console.ReadLine()!.Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            Console.WriteLine(prefixSum[x] - prefixSum[x - y]);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Promo");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}