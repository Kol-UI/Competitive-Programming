// Not Adjacent Matrix

namespace CompetitiveProgramming.CodeForces.NotAdjacentMatrix;
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
        for (int i = 0; i < numberOfTestCases; i++)
        {
            int n = ReadInt();
            if (n == 2)
            {
                Console.WriteLine("-1");
            }
            else
            {
                int[,] matrix = GenerateMatrix(n);
                PrintMatrix(matrix);
            }
        }
    }

    private static int[,] GenerateMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int odd = 1, even = 2;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = (odd <= n * n) ? odd : even;
                if (odd <= n * n) odd += 2;
                else even += 2;
            }
        }
        return matrix;
    }

    private static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
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

public class Solution2
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = ReadInt();
        List<string> results = new List<string>();

        for (int i = 0; i < t; i++)
        {
            int n = ReadInt();
            results.Add(GenerateMatrix(n));
        }

        PrintResults(results);
    }

    private static string GenerateMatrix(int n)
    {
        if (n == 1)
            return "1";
        if (n == 2)
            return "-1";

        int[,] matrix = new int[n, n];
        int current = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i + j) % 2 == 0)
                {
                    matrix[i, j] = current;
                    current++;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((i + j) % 2 != 0)
                {
                    matrix[i, j] = current;
                    current++;
                }
            }
        }

        return MatrixToString(matrix, n);
    }

    private static string MatrixToString(int[,] matrix, int n)
    {
        List<string> rows = new List<string>();
        for (int i = 0; i < n; i++)
        {
            List<string> row = new List<string>();
            for (int j = 0; j < n; j++)
            {
                row.Add(matrix[i, j].ToString());
            }
            rows.Add(string.Join(" ", row));
        }
        return string.Join("\n", rows);
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
        StyleHelper.Title("Not Adjacent Matrix");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}