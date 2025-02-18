// Setting up Camp
namespace CompetitiveProgramming.CodeForces.SettingupCamp;
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
        List<int> results = new List<int>();
        
        for (int i = 0; i < numberOfTestCases; i++)
        {
            int[] abc = ReadInts();
            results.Add(Solve(abc[0], abc[1], abc[2]));
        }
        
        PrintResults(results);
    }

    private static int Solve(int a, int b, int c)
    {
        return (c < (3 - b % 3) % 3) ? -1 : (a + (b + c + 2) / 3);
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
        StyleHelper.Title("Setting up Camp");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}