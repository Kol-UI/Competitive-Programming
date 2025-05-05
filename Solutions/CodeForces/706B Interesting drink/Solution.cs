// Interesting drink
namespace CompetitiveProgramming.CodeForces.Interestingdrink;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] arr = new int[n + 2];
        string[] input = Console.ReadLine()!.Split();
        for (int i = 1; i <= n; i++)
        {
            arr[i] = int.Parse(input[i - 1]);
        }
        Array.Sort(arr, 1, n);

        int q = int.Parse(Console.ReadLine()!);
        while (q-- > 0)
        {
            int m = int.Parse(Console.ReadLine()!);
            int l = 1;
            int r = n;
            int ans = 0;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (arr[mid] <= m)
                {
                    l = mid + 1;
                    ans = mid;
                }
                else
                {
                    r = mid - 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Interesting drink");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}