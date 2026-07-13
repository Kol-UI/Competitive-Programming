// Intuitive Elements
namespace CompetitiveProgramming.Kattis.IntuitiveElements;
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
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            HashSet<char> a = new HashSet<char>(s1);
            HashSet<char> b = new HashSet<char>(s2);

            bool isSubset = true;
            foreach (char c in b)
            {
                if (!a.Contains(c))
                {
                    isSubset = false;
                    break;
                }
            }

            Console.WriteLine(isSubset ? "YES" : "NO");
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
        StyleHelper.Title("Intuitive Elements");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}