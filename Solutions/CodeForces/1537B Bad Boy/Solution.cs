// Bad Boy
namespace CompetitiveProgramming.CodeForces.BadBoy;
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
        
        List<string> results = new List<string>();
        
        for (int i = 0; i < numberOfTestCases; i++)
        {
            int[] dimensions = ReadInts();
            int n = dimensions[0];
            int m = dimensions[1];
            int x = dimensions[2];
            int y = dimensions[3];
            
            var positions = GetMaxDistancePositions(n, m, x, y);
            results.Add($"{positions.Item1} {positions.Item2} {positions.Item3} {positions.Item4}");
        }
        
        PrintResults(results);
    }

    private static (int, int, int, int) GetMaxDistancePositions(int n, int m, int x, int y)
    {
        int x1 = 1, y1 = 1;
        int x2 = n, y2 = m;
        
        int distance1 = CalculateDistance(x, y, x1, y1) + CalculateDistance(x1, y1, x2, y2) + CalculateDistance(x2, y2, x, y);
        
        int x3 = 1, y3 = m;
        int x4 = n, y4 = 1;
        int distance2 = CalculateDistance(x, y, x3, y3) + CalculateDistance(x3, y3, x4, y4) + CalculateDistance(x4, y4, x, y);
        
        if (distance1 >= distance2)
        {
            return (x1, y1, x2, y2);
        }
        else
        {
            return (x3, y3, x4, y4);
        }
    }

    private static int CalculateDistance(int x1, int y1, int x2, int y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
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
        StyleHelper.Title("Bad Boy");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}