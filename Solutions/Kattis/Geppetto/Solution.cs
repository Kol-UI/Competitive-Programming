// Geppetto
namespace CompetitiveProgramming.Kattis.Geppetto;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static bool Works(HashSet<(int, int)> s, int n, int mask)
    {
        HashSet<int> inSet = new HashSet<int>();
        int i = 1;
        int temp = mask;
        
        while (temp > 0)
        {
            if ((temp & 1) == 1)
                inSet.Add(i);
            i++;
            temp >>= 1;
        }
        
        foreach (var pair in s)
        {
            if (inSet.Contains(pair.Item1) && inSet.Contains(pair.Item2))
                return false;
        }
        
        return true;
    }
    
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        
        HashSet<(int, int)> v = new HashSet<(int, int)>();
        for (int i = 0; i < m; i++)
        {
            string[] edge = Console.ReadLine().Split();
            int t1 = int.Parse(edge[0]);
            int t2 = int.Parse(edge[1]);
            if (t1 > t2)
            {
                int temp = t1;
                t1 = t2;
                t2 = temp;
            }
            v.Add((t1, t2));
        }
        
        int ans = 0;
        for (int mask = 0; mask < (1 << n); mask++)
        {
            if (Works(v, n, mask))
                ans++;
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Geppetto");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}