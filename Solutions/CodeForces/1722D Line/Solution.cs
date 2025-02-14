// Line

namespace CompetitiveProgramming.CodeForces.Line;
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
        int testCases = ReadInt();
        
        for (int tc = 0; tc < testCases; tc++)
        {
            int n = ReadInt();
            string line = ReadLn();
            
            Console.WriteLine(Solve(line));
        }
    }

    private static string Solve(string line)
    {
        long value = 0;
        int length = line.Length;
        int[] deltas = new int[length];

        for (int i = 0; i < length; i++)
        {
            int leftCount = i;
            int rightCount = length - 1 - i;
            
            if (line[i] == 'L')
            {
                value += leftCount;
                deltas[i] = Math.Max(0, rightCount - leftCount);
            }
            else
            {
                value += rightCount;
                deltas[i] = Math.Max(0, leftCount - rightCount);
            }
        }

        int[] sortedDeltas = deltas.OrderByDescending(x => x).ToArray();
        long[] result = new long[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = (i == 0 ? value : result[i - 1]) + sortedDeltas[i];
        }

        return string.Join(" ", result);
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
        StyleHelper.Title("Line");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}