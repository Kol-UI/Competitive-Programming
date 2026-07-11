// Tajna
namespace CompetitiveProgramming.Kattis.Tajna;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static int GetR(int n)
    {
        int r = 1;
        for (int i = 1; i * i <= n; i++)
        {
            if (n % i == 0) r = i;
        }
        return r;
    }
    
    static void Main()
    {
        string s = Console.ReadLine();
        int n = s.Length;
        int r = GetR(n);
        int c = n / r;
        
        char[][] grid = new char[r][];
        for (int j = 0; j < r; j++)
        {
            grid[j] = new char[c];
            for (int i = 0; i < c; i++)
            {
                grid[j][i] = s[i * r + j];
            }
        }
        
        for (int j = 0; j < r; j++)
        {
            for (int i = 0; i < c; i++)
            {
                Console.Write(grid[j][i]);
            }
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Tajna");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}