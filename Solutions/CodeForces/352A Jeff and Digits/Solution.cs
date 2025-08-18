// Jeff and Digits
namespace CompetitiveProgramming.CodeForces.JeffandDigits;
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
        int n = int.Parse(Console.ReadLine());
        int zeroes = 0, fives = 0;
        string[] inputs = Console.ReadLine().Split();

        foreach (string s in inputs)
        {
            int num = int.Parse(s);
            if (num == 0) zeroes++;
            else if (num == 5) fives++;
        }

        if (fives >= 9 && zeroes > 0)
        {
            for (int k = 0; k < fives / 9; k++) Console.Write("555555555");
            for (int k = 0; k < zeroes; k++) Console.Write("0");
            Console.WriteLine();
        }
        else if (zeroes > 0) Console.WriteLine("0");
        else Console.WriteLine("-1");
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
        StyleHelper.Title("Jeff and Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}