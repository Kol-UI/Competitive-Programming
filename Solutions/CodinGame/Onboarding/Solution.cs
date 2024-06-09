// Onboarding

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodinGame.Onboarding;

class Player
{
    //static void Main(string[] args)
    static void Solution()
    {
        // game loop
        while (true)
        {
            string enemy1 = Console.ReadLine()!; // name of enemy 1
            int dist1 = int.Parse(Console.ReadLine()!); // distance to enemy 1
            string enemy2 = Console.ReadLine()!; // name of enemy 2
            int dist2 = int.Parse(Console.ReadLine()!); // distance to enemy 2


            if (dist1 < dist2)
            {
                Console.WriteLine(enemy1);
            }
            else
            {
                Console.WriteLine(enemy2);
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Onboarding");
            ResultTester.SpecialTestCase(ProblemOrigin.CodinGame, ProblemCategory.OtherCodinGame);
        }
    }
}