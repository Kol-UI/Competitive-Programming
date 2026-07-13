// Conquest Campaign
namespace CompetitiveProgramming.Kattis.ConquestCampaign;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int r = int.Parse(firstLine[0]);
        int c = int.Parse(firstLine[1]);
        int n = int.Parse(firstLine[2]);

        HashSet<(int, int)> occu = new HashSet<(int, int)>();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            occu.Add((x, y));
        }

        int ans = 1;

        while (true)
        {
            HashSet<(int, int)> toAdd = new HashSet<(int, int)>();

            foreach (var (i, j) in occu)
            {
                int[] dx = { -1, 1, 0, 0 };
                int[] dy = { 0, 0, -1, 1 };

                for (int d = 0; d < 4; d++)
                {
                    int ni = i + dx[d];
                    int nj = j + dy[d];

                    if (ni >= 1 && ni <= r && nj >= 1 && nj <= c && !occu.Contains((ni, nj)))
                    {
                        toAdd.Add((ni, nj));
                    }
                }
            }

            if (toAdd.Count == 0)
                break;

            ans++;
            foreach (var pos in toAdd)
                occu.Add(pos);
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Conquest Campaign");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}