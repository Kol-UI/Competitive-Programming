// Fence
namespace CompetitiveProgramming.CodeForces.Fence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine()!.Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        int[] arr = new int[n];
        input = Console.ReadLine()!.Split();
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(input[i]);

        if (n == k)
        {
            Console.WriteLine(1);
            return;
        }

        long min = long.MaxValue;
        long temp = 0;
        int ans = 0;

        for (int i = 0; i < k; i++)
            temp += arr[i];

        for (int i = 0; i < n - k + 1; i++)
        {
            if (temp < min)
            {
                min = temp;
                ans = i + 1;
            }
            if (i + k < n)
                temp = temp - arr[i] + arr[i + k];
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}