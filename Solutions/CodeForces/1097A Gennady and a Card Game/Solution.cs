// Gennady and a Card Game

namespace CompetitiveProgramming.CodeForces.GennadyandaCardGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Solution
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        string tableCard = Console.ReadLine()!;
        string[] handCards = Console.ReadLine()!.Split(' ');

        bool canPlay = false;

        foreach (string handCard in handCards)
        {
            if (handCard[0] == tableCard[0] || handCard[1] == tableCard[1])
            {
                canPlay = true;
                break;
            }
        }

        Console.WriteLine(canPlay ? "YES" : "NO");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Gennady and a Card Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}