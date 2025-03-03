// Decode String
namespace CompetitiveProgramming.CodeForces.DecodeString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            ReadInt();
            string t = ReadLn();
            results.Add(Solve(t));
        }

        PrintResults(results);
    }

    private static string Solve(string t)
    {
        StringBuilder reversed = new StringBuilder();
        int index = t.Length - 1;
        
        while (index != -1)
        {
            if (t[index] == '0')
            {
                reversed.Append((char)(10 * (t[index - 2] - '0') + (t[index - 1] - '0') - 1 + 'a'));
                index -= 3;
            }
            else
            {
                reversed.Append((char)((t[index] - '0') - 1 + 'a'));
                --index;
            }
        }

        return new string(reversed.ToString().Reverse().ToArray());
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
        StyleHelper.Title("Decode String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}