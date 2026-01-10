// Going to office

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerEarth.Goingtooffice;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int distance = ReadInt();
        int[] onlineTaxi = ReadInts();
        int[] classicTaxi = ReadInts();
        
        int temp = distance - onlineTaxi[1];
        int onlineCost = temp > 0 ? onlineTaxi[0] + temp * onlineTaxi[2] : onlineTaxi[0];
        
        int time = distance / classicTaxi[0];
        int classicCost = classicTaxi[1] + classicTaxi[2] * time + classicTaxi[3] * distance;
        
        Console.WriteLine(onlineCost <= classicCost ? "Online Taxi" : "Classic Taxi");
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
        StyleHelper.Title("Going to office");
        ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
    }
}