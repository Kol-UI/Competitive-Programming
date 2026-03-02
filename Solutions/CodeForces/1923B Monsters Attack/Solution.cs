// Monsters Attack!
namespace CompetitiveProgramming.CodeForces.MonstersAttack;
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
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0];
            int k = input[1];
            
            int[] health = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] position = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            List<(int dist, int health)> monsters = new List<(int, int)>();
            
            for(int p = 0; p < n; p++)
            {
                int dist = Math.Abs(position[p]);
                monsters.Add((dist, health[p]));
            }
            
            var sorted = monsters.OrderBy(x => x.dist).ToList();
            
            long totalShots = 0;
            int currentDist = 0;
            bool possible = true;
            
            for(int p = 0; p < n && possible; p++)
            {
                totalShots += (sorted[p].dist - currentDist) * (long)k;
                totalShots -= sorted[p].health;
                currentDist = sorted[p].dist;
                
                if(totalShots < 0) possible = false;
            }
            
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Monsters Attack!");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}