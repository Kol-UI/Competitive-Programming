// Akcija
namespace CompetitiveProgramming.Kattis.Akcija;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(a);
        Array.Reverse(a);
        
        int sum = a.Sum();
        int sumEveryThird = 0;
        for (int i = 2; i < n; i += 3)
        {
            sumEveryThird += a[i];
        }
        
        Console.WriteLine(sum - sumEveryThird);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Akcija");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}