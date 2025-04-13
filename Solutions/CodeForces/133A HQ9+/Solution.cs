// HQ9+
namespace CompetitiveProgramming.CodeForces.HQ9Plus;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string word = Console.ReadLine()!;
        string ans = "NO";
        foreach (char c in word)
        {
            if (c == 'H' || c == 'Q' || c == '9')
            {
                ans = "YES";
                break;
            }
        }
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("HQ9+");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}