// Mike and palindrome
namespace CompetitiveProgramming.CodeForces.Mikeandpalindrome;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string str = Console.ReadLine()!;
        bool ok = true;
        int cnt = 0;
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                cnt++;
                if (cnt > 1)
                {
                    ok = false;
                    break;
                }
            }
        }
        if (cnt < 1 && (str.Length % 2 == 0))
            ok = false;
        Console.WriteLine(ok ? "YES" : "NO");
    }
}

public class TestSolution : Models.BaseSolution
{
    public override void GetResult()
    {
        Helpers.StyleHelper.Space();
        Helpers.StyleHelper.Title("Mike and palindrome");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}