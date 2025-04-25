// Clock and Strings
namespace CompetitiveProgramming.CodeForces.ClockandStrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int tc = int.Parse(Console.ReadLine()!);
        while (tc-- > 0)
        {
            int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int a = input[0], b = input[1], c = input[2], d = input[3];
            
            if (a > b) (a, b) = (b, a);
            if (c > d) (c, d) = (d, c);
            
            bool ok = false;
            ok |= (a < c && d < b);
            ok |= (c < a && b < d);
            ok |= (b < c);
            ok |= (d < a);
            
            Console.WriteLine(!ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Clock and Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}