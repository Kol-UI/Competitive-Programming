// Card Game
namespace CompetitiveProgramming.CodeForces.CardGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static int Compare(int x, int y) => x > y ? 1 : (x < y ? -1 : 0);

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] values = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = values[0], b = values[1], c = values[2], d = values[3];
            
            int case1 = Compare(a, c) + Compare(b, d);
            int case2 = Compare(a, d) + Compare(b, c);
            
            int res = (case1 > 0 ? 2 : 0) + (case2 > 0 ? 2 : 0);
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Card Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}