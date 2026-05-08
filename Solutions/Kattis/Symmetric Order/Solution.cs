// Symmetric Order
namespace CompetitiveProgramming.Kattis.SymmetricOrder;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n;
        int j = 0;
        string line;
        
        while ((line = Console.ReadLine()) != null)
        {
            n = int.Parse(line);
            if (n == 0) break;
            
            j++;
            List<string> v = new List<string>();
            
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                v.Add(s);
            }
            
            Console.WriteLine($"SET {j}");
            
            if (v.Count % 2 == 1)
            {
                int i = 0;
                for (i = 0; i < v.Count; i += 2)
                {
                    Console.WriteLine(v[i]);
                }
                i -= 3;
                for (; i >= 0; i -= 2)
                {
                    Console.WriteLine(v[i]);
                }
            }
            else
            {
                int i = 0;
                for (i = 0; i < v.Count; i += 2)
                {
                    Console.WriteLine(v[i]);
                }
                i -= 1;
                for (; i >= 0; i -= 2)
                {
                    Console.WriteLine(v[i]);
                }
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Symmetric Order");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}