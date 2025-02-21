// Lucky Ticket
namespace CompetitiveProgramming.CodeForces.LuckyTicket;
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
        int n = ReadInt();
        string ticket = ReadLn();
        
        bool isLucky = IsLuckyTicket(n, ticket);
        Console.WriteLine(isLucky ? "YES" : "NO");
    }

    private static bool IsLuckyTicket(int n, string ticket)
    {
        if (!IsLuckyNumber(ticket))
            return false;

        int half = n / 2;
        int sumFirstHalf = SumDigits(ticket.Substring(0, half));
        int sumSecondHalf = SumDigits(ticket.Substring(half, half));

        return sumFirstHalf == sumSecondHalf;
    }

    private static bool IsLuckyNumber(string number)
    {
        foreach (char c in number)
        {
            if (c != '4' && c != '7')
                return false;
        }
        return true;
    }

    private static int SumDigits(string s)
    {
        int sum = 0;
        foreach (char c in s)
        {
            sum += int.Parse(c.ToString());
        }
        return sum;
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
        StyleHelper.Title("Lucky Ticket");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}