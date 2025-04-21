// 01 Game
namespace CompetitiveProgramming.CodeForces.ZeroOneGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string str = Console.ReadLine()!;
            int one = str.Count(c => c == '1');
            int mn = Math.Min(one, str.Length - one);
            Console.WriteLine(mn % 2 == 1 ? "DA" : "NET");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("01 Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}