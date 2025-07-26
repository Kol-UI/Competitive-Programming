// Yet Another Card Deck
namespace CompetitiveProgramming.CodeForces.YetAnotherCardDeck;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int[] nq = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nq[0], q = nq[1];
        
        int[] cards = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] queries = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Dictionary<int, int> positions = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            if (!positions.ContainsKey(cards[i]))
            {
                positions[cards[i]] = i + 1;
            }
        }
        
        StringBuilder result = new StringBuilder();
        int top = 1;
        
        foreach (int target in queries)
        {
            int pos = positions[target];
            result.Append(pos + " ");
            
            foreach (var color in positions.Keys.ToList())
            {
                if (positions[color] < pos)
                {
                    positions[color]++;
                }
            }
            
            positions[target] = top;
        }
        
        Console.WriteLine(result.ToString().Trim());
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Yet Another Card Deck");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}