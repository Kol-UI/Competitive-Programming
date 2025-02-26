// Rule of League
namespace CompetitiveProgramming.CodeForces.RuleofLeague;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        for (int i = 0; i < numberOfTestCases; i++)
        {
            Solve();
        }
    }

    private static void Solve()
    {
        int[] input = ReadInts();
        int n = input[0];
        int x = input[1];
        int y = input[2];

        if (x + y == 0 || (x > 0 && y > 0))
        {
            Console.WriteLine("-1");
            return;
        }

        if (x == 0)
        {
            if ((n - 1) % y != 0)
            {
                Console.WriteLine("-1");
                return;
            }

            for (int i = 1; i <= (n - 1) / y; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(i == 1 ? 2 : (i - 1) * y + 2);
                    if (i != (n - 1) / y || j != y-1)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
        else
        {
            if ((n - 1) % x != 0)
            {
                Console.WriteLine("-1");
                return;
            }

            for (int i = 1; i <= (n - 1) / x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(i == 1 ? 2 : (i - 1) * x + 2);
                    if (i != (n - 1) / x || j != x-1)
                        Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintDouble(double value, int decimals) => Console.WriteLine(value.ToString($"F{decimals}"));
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rule of League");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}