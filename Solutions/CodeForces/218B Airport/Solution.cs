// Airport

namespace CompetitiveProgramming.CodeForces.Airport;
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
        int[] nm = ReadInts();
        int n = nm[0];
        int m = nm[1];
        int[] seats = ReadInts();

        int maxRevenue = CalculateMaxRevenue(n, m, seats);
        int minRevenue = CalculateMinRevenue(n, m, seats);

        Console.WriteLine($"{maxRevenue} {minRevenue}");
    }

    private static int CalculateMaxRevenue(int n, int m, int[] seats)
    {
        int[] sortedSeats = seats.OrderByDescending(x => x).ToArray();
        int revenue = 0;
        for (int i = 0; i < n; i++)
        {
            revenue += sortedSeats[0];
            sortedSeats[0]--;
            sortedSeats = sortedSeats.OrderByDescending(x => x).ToArray();
        }
        return revenue;
    }

    private static int CalculateMinRevenue(int n, int m, int[] seats)
    {
        int[] sortedSeats = seats.OrderBy(x => x).ToArray();
        int revenue = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (sortedSeats[j] > 0)
                {
                    revenue += sortedSeats[j];
                    sortedSeats[j]--;
                    break;
                }
            }
        }
        return revenue;
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
        StyleHelper.Title("Airport");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}