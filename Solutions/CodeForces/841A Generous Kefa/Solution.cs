// Generous Kefa
namespace CompetitiveProgramming.CodeForces.GenerousKefa;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        string s = Console.ReadLine();
        
        int[] freq = new int[26];
        foreach (char c in s) freq[c - 'a']++;
        
        bool possible = true;
        foreach (int count in freq)
        {
            if (count > k)
            {
                possible = false;
                break;
            }
        }
        
        Console.WriteLine(possible ? "YES" : "NO");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Generous Kefa");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}