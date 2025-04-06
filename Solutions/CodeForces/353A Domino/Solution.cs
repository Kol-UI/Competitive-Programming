// Domino
namespace CompetitiveProgramming.CodeForces.Domino;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        int u = 0, l = 0;
        bool dif = false;
        
        while (t-- > 0)
        {
            int[] ab = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int a = ab[0], b = ab[1];
            if (a % 2 != b % 2)
                dif = true;
            u += a;
            l += b;
        }

        if (u % 2 == 0 && l % 2 == 0)
            Console.WriteLine(0);
        else if ((u % 2 == 1) && (l % 2 == 1) && dif)
            Console.WriteLine(1);
        else
            Console.WriteLine(-1);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Domino");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}