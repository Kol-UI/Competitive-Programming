// Twins
namespace CompetitiveProgramming.CodeForces.Twins;
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
        int coin = int.Parse(Console.ReadLine()!);
        int[] value = new int[coin];
        string[] input = Console.ReadLine()!.Split();
        for (int i = 0; i < coin; i++)
            value[i] = int.Parse(input[i]);

        int sum = value.Sum();
        int half = sum / 2;
        Array.Sort(value);
        Array.Reverse(value);

        int cnt = 0, ans = 0;
        for (int i = 0; i < coin; i++)
        {
            if (cnt > half) break;
            cnt += value[i];
            ans++;
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Twins");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}