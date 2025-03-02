// Balls of Buma
namespace CompetitiveProgramming.CodeForces.BallsofBuma;
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
        string colors = ReadLn();
        Console.WriteLine(Solve(colors));
    }

    private static int Solve(string colors)
    {
        List<Segment> segments = new List<Segment>();
        int count = -1;
        
        for (int i = 0; i <= colors.Length; ++i)
        {
            if (i != colors.Length && i != 0 && colors[i] == colors[i - 1])
            {
                ++count;
            }
            else
            {
                if (i != 0)
                {
                    segments.Add(new Segment(colors[i - 1], count));
                }
                count = 1;
            }
        }
        
        return (segments.Count % 2 == 1
            && segments[segments.Count / 2].Length >= 2
            && Enumerable.Range(0, segments.Count / 2).All(i =>
                segments[i].Color == segments[segments.Count - 1 - i].Color
                && segments[i].Length + segments[segments.Count - 1 - i].Length >= 3))
            ? (segments[segments.Count / 2].Length + 1)
            : 0;
    }

    private record Segment(char Color, int Length);
    
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
        StyleHelper.Title("Balls of Buma");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}