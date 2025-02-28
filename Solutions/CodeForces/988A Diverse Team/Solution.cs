// Diverse Team
namespace CompetitiveProgramming.CodeForces.DiverseTeam;
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
        int[] nk = ReadInts();
        int n = nk[0];
        int k = nk[1];
        int[] a = ReadInts();

        Console.Write(Solve(a, k));
    }

    static string Solve(int[] a, int k)
    {
        Dictionary<int, int> ratingToIndex = new Dictionary<int, int>();
        List<int> resultIndices = new List<int>();

        for (int i = 0; i < a.Length; i++)
        {
            if (!ratingToIndex.ContainsKey(a[i]))
            {
                ratingToIndex.Add(a[i], i + 1);
                resultIndices.Add(i + 1);
            }
        }

        if (ratingToIndex.Count < k)
        {
            return "NO";
        }
        else
        {
            return $"YES\n{string.Join(" ", resultIndices.Take(k))}";
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
    private static int[] ReadInts(int count)
    {
        int[] result = new int[count];
        string[] input = ReadStrings();
        for (int i = 0; i < count; i++)
        {
            result[i] = int.Parse(input[i]);
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Diverse Team");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}