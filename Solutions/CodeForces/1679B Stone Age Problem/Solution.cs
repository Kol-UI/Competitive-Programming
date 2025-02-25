// Stone Age Problem
namespace CompetitiveProgramming.CodeForces.StoneAgeProblem;
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
        var results = Solve();
        PrintResults(results);
    }

    private static List<long> Solve()
    {
        int[] nq = ReadInts();
        int n = nq[0], q = nq[1];
        long[] a = ReadInts().Select(x => (long)x).ToArray();
        long sum = a.Sum();
        List<long> results = new();
        long lastSetValue = -1;
        bool isUniform = false;
        Dictionary<int, long> modifiedElements = new();

        for (int j = 0; j < q; j++)
        {
            int[] query = ReadInts();
            if (query[0] == 1)
            {
                int i = query[1] - 1;
                long x = query[2];

                if (isUniform)
                {
                    if (!modifiedElements.ContainsKey(i))
                        modifiedElements[i] = lastSetValue;
                    
                    sum += x - modifiedElements[i];
                    modifiedElements[i] = x;
                }
                else
                {
                    sum += x - a[i];
                    a[i] = x;
                }
            }
            else
            {
                lastSetValue = query[1];
                sum = (long)n * lastSetValue;
                isUniform = true;
                modifiedElements.Clear();
            }
            results.Add(sum);
        }
        return results;
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
        StyleHelper.Title("Stone Age Problem");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}