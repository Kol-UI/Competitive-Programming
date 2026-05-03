// Pivot
namespace CompetitiveProgramming.Kattis.Pivot;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        SortedSet<int> left = new SortedSet<int>();
        SortedSet<int> right = new SortedSet<int>();
        
        for (int i = 0; i < n; i++)
            right.Add(a[i]);
        
        int ans = 0;
        
        for (int i = 0; i < n; i++)
        {
            right.Remove(a[i]);
            
            bool conditionLeft = (i == 0 || left.Max <= a[i]);
            bool conditionRight = (i == n - 1 || right.Min > a[i]);
            
            if (conditionLeft && conditionRight)
                ans++;
            
            left.Add(a[i]);
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pivot");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}