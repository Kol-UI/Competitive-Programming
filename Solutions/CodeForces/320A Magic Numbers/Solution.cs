// Magic Numbers
namespace CompetitiveProgramming.CodeForces.MagicNumbers;
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
        bool one = false;
        bool ok = true;
        int four = 0;

        foreach (char c in str)
        {
            if (c == '1')
            {
                one = true;
                four = 0;
            }
            else if (c == '4')
            {
                if (!one)
                {
                    ok = false;
                    break;
                }
                else
                {
                    four++;
                    if (four > 2)
                    {
                        ok = false;
                        break;
                    }
                }
            }
            else
            {
                ok = false;
                break;
            }
        }

        Console.WriteLine(ok ? "YES" : "NO");
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Magic Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}