// Boboniu Likes to Color Balls
namespace CompetitiveProgramming.CodeForces.BoboniuLikestoColorBalls;
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
            long[] balls = ReadLongs();
            long r = balls[0];
            long g = balls[1];
            long b = balls[2];
            long w = balls[3];
            
            results.Add(CanFormPalindrome(r, g, b, w) ? "Yes" : "No");
        }
        
        PrintResults(results);
    }

    private static bool CanFormPalindrome(long r, long g, long b, long w)
    {
        int oddCount = CountOdd(r, g, b, w);
        
        if (oddCount <= 1)
            return true;
        
        if (r > 0 && g > 0 && b > 0)
        {
            r--;
            g--;
            b--;
            w += 3;
            oddCount = CountOdd(r, g, b, w);
            
            if (oddCount <= 1)
                return true;
        }
        
        return false;
    }

    private static int CountOdd(long r, long g, long b, long w)
    {
        int count = 0;
        if (r % 2 != 0) count++;
        if (g % 2 != 0) count++;
        if (b % 2 != 0) count++;
        if (w % 2 != 0) count++;
        return count;
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
        StyleHelper.Title("Boboniu Likes to Color Balls");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}