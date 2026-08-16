// Turtle and Good Pairs
namespace CompetitiveProgramming.CodeForces.TurtleandGoodPairs;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            
            int[] freq = new int[26];
            foreach (char c in s)
                freq[c - 'a']++;
            
            char[] result = new char[n];
            int idx = 0;
            
            while (idx < n)
            {
                for (int i = 0; i < 26 && idx < n; i++)
                {
                    if (freq[i] > 0)
                    {
                        result[idx++] = (char)('a' + i);
                        freq[i]--;
                    }
                }
            }
            
            Console.WriteLine(new string(result));
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
        StyleHelper.Title("Turtle and Good Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}