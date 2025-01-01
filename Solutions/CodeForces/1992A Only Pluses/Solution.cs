// Only Pluses

namespace CompetitiveProgramming.CodeForces.OnlyPluses;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    private const int LIMIT = 5;

    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int numberOfTestCases = ReadInt();
        List<int> results = new List<int>();

        for (int i = 0; i < numberOfTestCases; i++)
        {
            int[] abc = ReadInts();
            int a = abc[0], b = abc[1], c = abc[2];

            results.Add(Solve(a, b, c));
        }

        PrintResults(results);
    }

    static int Solve(int a, int b, int c)
    {
        int maxProduct = -1;
    
        for (int da = 0; da <= LIMIT; da++)
        {
            for (int db = 0; db <= LIMIT - da; db++)
            {
                int dc = LIMIT - da - db;
    
                int currentProduct = (a + da) * (b + db) * (c + dc);
                maxProduct = Math.Max(maxProduct, currentProduct);
            }
        }
    
        return maxProduct;
    }


    private static string ReadLn() => Console.ReadLine()!;
    private static int ReadInt() => int.Parse(ReadLn());
    private static long ReadLong() => long.Parse(ReadLn());
    private static double ReadDouble() => double.Parse(ReadLn());
    private static string[] ReadStrings() => ReadLn().Split(' ');
    private static int[] ReadInts() => ReadStrings().Select(int.Parse).ToArray();
    private static long[] ReadLongs() => ReadStrings().Select(long.Parse).ToArray();
    private static double[] ReadDoubles() => ReadStrings().Select(double.Parse).ToArray();
    private static void PrintResults<T>(List<T> results) => results.ForEach(result => Console.WriteLine(result?.ToString()));
}



public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Only Pluses");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}