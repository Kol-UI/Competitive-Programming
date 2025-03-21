// Monsters
namespace CompetitiveProgramming.CodeForces.Monsters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            var input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int n = input[0], k = input[1];

            var monsters = new List<(int health, int index)>();

            var healthValues = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                int health = healthValues[i];
                int effectiveHealth = (health % k == 0) ? k : health % k;
                monsters.Add((effectiveHealth, i + 1));
            }

            monsters = monsters.OrderByDescending(m => m.health)
                               .ThenBy(m => m.index)
                               .ToList();

            foreach (var monster in monsters)
            {
                Console.Write(monster.index + " ");
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
        StyleHelper.Title("Monsters");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}