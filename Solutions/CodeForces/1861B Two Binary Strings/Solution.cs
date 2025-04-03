// Two Binary Strings
namespace CompetitiveProgramming.CodeForces.TwoBinaryStrings;
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
            string a = Console.ReadLine()!, b = Console.ReadLine()!;
            bool ok = false;
            for (int i = 0; i + 1 < a.Length; i++)
            {
                if ((a[i] == b[i] && a[i] == '0') && (a[i + 1] == b[i + 1] && a[i + 1] == '1'))
                {
                    ok = true;
                    break;
                }
            }
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Two Binary Strings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}