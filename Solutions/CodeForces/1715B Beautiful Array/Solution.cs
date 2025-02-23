// Beautiful Array
namespace CompetitiveProgramming.CodeForces.BeautifulArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        
        for (int i = 0; i < numberOfTestCases; i++)
        {
            long[] input = ReadLongs();
            long n = input[0], k = input[1], b = input[2], s = input[3];
            List<long> result = Solve(n, k, b, s);
            if (result == null)
                Console.WriteLine(-1);
            else
                Console.WriteLine(string.Join(" ", result));
        }
    }

    private static List<long> Solve(long n, long k, long b, long s)
    {
        if (b * k > s || s > b * k + n * (k - 1))
            return null;
        
        List<long> a = new List<long>();
        long remaining = s - b * k;
        
        for (int i = 0; i < n; i++)
        {
            if (remaining >= k - 1)
            {
                a.Add(k - 1);
                remaining -= k - 1;
            }
            else
            {
                a.Add(remaining);
                remaining = 0;
            }
        }
        
        a[0] += b * k;
        return a;
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
#nullable enable

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Beautiful Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}