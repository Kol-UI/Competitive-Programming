// Kiki Boba
namespace CompetitiveProgramming.Kattis.KikiBoba;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        Dictionary<char, int> c = new Dictionary<char, int> { { 'b', 0 }, { 'k', 0 } };
        
        foreach (char ch in s)
        {
            if (ch == 'b') c['b']++;
            else if (ch == 'k') c['k']++;
        }
        
        if (c['b'] == 0 && c['k'] == 0)
        {
            Console.WriteLine("none");
        }
        else if (c['b'] == c['k'])
        {
            Console.WriteLine("boki");
        }
        else if (c['b'] > c['k'])
        {
            Console.WriteLine("boba");
        }
        else
        {
            Console.WriteLine("kiki");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kiki Boba");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}