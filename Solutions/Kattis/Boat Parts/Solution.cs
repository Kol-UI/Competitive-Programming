// Boat Parts
namespace CompetitiveProgramming.Kattis.BoatParts;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        
        HashSet<string> s = new HashSet<string>();
        bool print = false;
        
        for (int i = 1; i <= m; i++)
        {
            string t = Console.ReadLine();
            s.Add(t);
            if (s.Count == n)
            {
                Console.WriteLine(i);
                print = true;
                break;
            }
        }
        
        if (!print)
        {
            Console.WriteLine("paradox avoided");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Boat Parts");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}