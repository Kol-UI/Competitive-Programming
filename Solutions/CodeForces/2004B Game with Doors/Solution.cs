// Game with Doors
namespace CompetitiveProgramming.CodeForces.GamewithDoors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] input1 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long l = input1[0], r = input1[1];
            long[] input2 = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long L = input2[0], R = input2[1];

            long mxl = Math.Max(l, L);
            long mnr = Math.Min(r, R);
            long len = mnr - mxl;
            long res = len + (l != L ? 1 : 0) + (r != R ? 1 : 0);
            res = len >= 0 ? res : 1;
            
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
        StyleHelper.Title("Game with Doors");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}