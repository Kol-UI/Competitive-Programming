// Delete from the Left
namespace CompetitiveProgramming.CodeForces.DeletefromtheLeft;
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
        string s = Console.ReadLine();
        string t = Console.ReadLine();
        long moves = 0;
        bool diff = false;
        long p = s.Length - 1;
        long q = t.Length - 1;
        while (p >= 0 || q >= 0)
        {
            if (p < 0 || q < 0)
            {
                moves++;
                p--;
                q--;
                continue;
            }
            if (s[(int)p] != t[(int)q]) diff = true;
            if (diff) moves += 2;
            p--;
            q--;
        }
        Console.WriteLine(moves);
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
        StyleHelper.Title("Delete from the Left");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}