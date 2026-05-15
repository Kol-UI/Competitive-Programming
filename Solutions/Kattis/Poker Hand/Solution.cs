// Poker Hand
namespace CompetitiveProgramming.Kattis.PokerHand;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();
        char[] firstLetters = words.Select(w => w[0]).ToArray();
        
        var counts = firstLetters.GroupBy(c => c).Select(g => new { Letter = g.Key, Count = g.Count() });
        
        int maxCount = counts.Max(c => c.Count);
        Console.WriteLine(maxCount);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Poker Hand");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}