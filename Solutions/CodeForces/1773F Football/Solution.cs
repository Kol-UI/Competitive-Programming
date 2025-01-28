// Football

namespace CompetitiveProgramming.CodeForces.Football;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int n = ReadInt();
        int a = ReadInt();
        int b = ReadInt();

        Console.WriteLine(Solve(n, a, b));
    }

    static string Solve(int n, int a, int b)
    {
        int[] scored = new int[n];
        int[] conceded = new int[n];

        for (int i = 0; i < n; ++i)
        {
            if (i == n - 1)
            {
                scored[i] = a;
                conceded[i] = b;
            }
            else if (a < b)
            {
                if (a == 0)
                {
                    scored[i] = 0;
                    conceded[i] = 1;
                }
                else
                {
                    scored[i] = 1;
                    conceded[i] = 0;
                }
            }
            else if (a > b)
            {
                if (b == 0)
                {
                    scored[i] = 1;
                    conceded[i] = 0;
                }
                else
                {
                    scored[i] = 0;
                    conceded[i] = 1;
                }
            }
            else if (a == 0)
            {
                scored[i] = 0;
                conceded[i] = 0;
            }
            else
            {
                scored[i] = 1;
                conceded[i] = 0;
            }

            a -= scored[i];
            b -= conceded[i];
        }

        var draws = scored.Zip(conceded, (x, y) => x == y).Count(equal => equal);
        var matches = string.Join("\n", scored.Zip(conceded, (x, y) => $"{x}:{y}"));

        return $"{draws}\n{matches}";
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
        StyleHelper.Title("Football");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}