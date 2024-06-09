// Echo Echo Echo



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.Kattis.EchoEchoEcho
{
    public class Program
    {
        //public static void Main(string[] args)
        public static void Solution()
        {
            string word = Console.ReadLine()!.Trim();

            Console.WriteLine($"{word} {word} {word}");
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Echo Echo Echo");
            ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
        }
    }
}