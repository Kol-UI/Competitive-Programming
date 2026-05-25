// Guessing Game
namespace CompetitiveProgramming.Kattis.GuessingGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        bool[] poss = Enumerable.Repeat(true, 10).ToArray();
        bool dh = false;
        
        while (true)
        {
            int g = int.Parse(Console.ReadLine());
            if (g == 0) break;
            
            string resp = Console.ReadLine();
            
            if (resp == "right on")
            {
                if (dh || !poss[g - 1])
                    Console.WriteLine("Stan is dishonest");
                else
                    Console.WriteLine("Stan may be honest");
                
                poss = Enumerable.Repeat(true, 10).ToArray();
                dh = false;
                continue;
            }
            
            if (resp == "too high")
            {
                if (!poss[g - 1] && poss.Skip(g - 1).Any(p => p))
                    dh = true;
                for (int i = g - 1; i < 10; i++)
                    poss[i] = false;
            }
            else
            {
                if (!poss[g - 1] && poss.Take(g).Any(p => p))
                    dh = true;
                for (int i = 0; i < g; i++)
                    poss[i] = false;
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Guessing Game");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}