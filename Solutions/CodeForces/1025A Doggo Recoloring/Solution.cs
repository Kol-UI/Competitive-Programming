// Doggo Recoloring
namespace CompetitiveProgramming.CodeForces.DoggoRecoloring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        
        int[] frequency = new int[26];
        foreach (char c in s)
        {
            frequency[c - 'a']++;
        }
        
        bool isPossible = s.Length <= 1;
        foreach (int count in frequency)
        {
            if (count > 1)
            {
                isPossible = true;
                break;
            }
        }
        
        Console.WriteLine(isPossible ? "Yes" : "No");
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
        StyleHelper.Title("Doggo Recoloring");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}