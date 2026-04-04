// ASCII Kassi 2
namespace CompetitiveProgramming.Kattis.ASCIIKassiTwo;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

public class Solution
{
    static public void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine(new string(' ', n + 1) + "x");
        
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + "/" + new string(' ', 2 * i + 1) + "\\");
        }
        
        Console.WriteLine("x" + new string(' ', 2 * n + 1) + "x");
        
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(' ', i + 1) + "\\" + new string(' ', 2 * (n - i) - 1) + "/");
        }
        
        Console.WriteLine(new string(' ', n + 1) + "x");
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("ASCII Kassi 2");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}