// Robotic moves
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using System;
namespace CompetitiveProgramming.HackerEarth.Roboticmoves
{

    public class Program
    {
        //public static void Main()
        public static void MainSolution()
        {
            int t = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine()!);
                Console.WriteLine(n * (n + 1));
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Robotic moves");
            ResultTester.SpecialTestCase(ProblemOrigin.HackerEarth, ProblemCategory.EasyHE);
        }
    }
}