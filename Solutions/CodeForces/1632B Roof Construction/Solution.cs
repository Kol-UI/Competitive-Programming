// Roof Construction
namespace CompetitiveProgramming.CodeForces.RoofConstruction;
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
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            n--;
            int x = (int)Math.Log2(n);
            x = (int)Math.Pow(2, x);
            while (n >= x)
                Console.Write(n-- + " ");
            Console.Write(0);
            while (n > 0)
                Console.Write(" " + n--);
            Console.WriteLine();
        }
    }
}


public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Roof Construction");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}