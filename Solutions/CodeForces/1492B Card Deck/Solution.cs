// Card Deck
namespace CompetitiveProgramming.CodeForces.CardDeck;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] v = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            List<int> peaks = new List<int>();
            long maxSoFar = 0;
            
            for(int p = 0; p < n; p++)
            {
                if(v[p] > maxSoFar)
                {
                    maxSoFar = v[p];
                    peaks.Add(p);
                }
            }
            peaks.Add(n);
            
            for(int p = peaks.Count - 2; p >= 0; p--)
            {
                int start = peaks[p];
                int end = peaks[p + 1];
                for(int q = start; q < end; q++)
                {
                    Console.Write($"{v[q]} ");
                }
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Card Deck");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}