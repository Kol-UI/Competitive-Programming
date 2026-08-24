// Pizza Hawaii
namespace CompetitiveProgramming.Kattis.PizzaHawaii;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine()!);

        for (int tc = 0; tc < testCases; tc++)
        {
            int n = int.Parse(Console.ReadLine()!);
            var fSet = new Dictionary<string, HashSet<string>>();
            var nSet = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string pizza = Console.ReadLine()!;

                string[] fore = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                foreach (var w in fore)
                {
                    if (!fSet.ContainsKey(w))
                    {
                        fSet[w] = new HashSet<string>();
                    }
                    fSet[w].Add(pizza);
                }

                string[] nati = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
                foreach (var w in nati)
                {
                    if (!nSet.ContainsKey(w))
                    {
                        nSet[w] = new HashSet<string>();
                    }
                    nSet[w].Add(pizza);
                }
            }

            var ansPairs = new List<(string V, string W)>();

            foreach (var kvp1 in fSet)
            {
                foreach (var kvp2 in nSet)
                {
                    if (kvp1.Value.SetEquals(kvp2.Value))
                    {
                        ansPairs.Add((kvp1.Key, kvp2.Key));
                    }
                }
            }

            ansPairs.Sort((a, b) =>
            {
                int comp = string.Compare(a.V, b.V, StringComparison.Ordinal);
                return comp != 0 ? comp : string.Compare(a.W, b.W, StringComparison.Ordinal);
            });

            foreach (var pair in ansPairs)
            {
                Console.WriteLine($"({pair.V}, {pair.W})");
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pizza Hawaii");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}