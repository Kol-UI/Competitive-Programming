// Hangman
namespace CompetitiveProgramming.Kattis.Hangman;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string word = Console.ReadLine();
        string perm = Console.ReadLine();
        
        HashSet<char> st = new HashSet<char>();
        foreach (char c in word)
        {
            st.Add(c);
        }
        
        int wrong = 0;
        
        foreach (char c in perm)
        {
            if (st.Contains(c))
            {
                st.Remove(c);
                if (st.Count == 0)
                {
                    Console.WriteLine("WIN");
                    return;
                }
            }
            else
            {
                wrong++;
                if (wrong == 10)
                {
                    Console.WriteLine("LOSE");
                    return;
                }
            }
        }
        
        Console.WriteLine("WIN");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hangman");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}