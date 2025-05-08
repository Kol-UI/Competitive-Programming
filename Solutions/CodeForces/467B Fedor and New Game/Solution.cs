// Fedor and New Game
namespace CompetitiveProgramming.CodeForces.FedorandNewGame;
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
        int m = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        int[] arr = new int[m + 1];
        for (int i = 0; i <= m; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()!);
        }

        int ans = 0;
        for (int i = 0; i < m; i++)
        {
            int dif = CountBits(arr[m] ^ arr[i]);
            if (dif <= k)
                ans++;
        }

        Console.WriteLine(ans);
    }

    static int CountBits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Fedor and New Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}