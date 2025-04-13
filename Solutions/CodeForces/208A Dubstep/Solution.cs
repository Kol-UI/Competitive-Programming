// Dubstep
namespace CompetitiveProgramming.CodeForces.Dubstep;
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
        bool ok = false;
        for (int i = 0; i < str.Length; i++)
        {
            if (i + 2 < str.Length && str[i] == 'W' && str[i + 1] == 'U' && str[i + 2] == 'B')
            {
                i += 2;
                if (ok)
                {
                    Console.Write(' ');
                }
            }
            else
            {
                Console.Write(str[i]);
                ok = true;
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Dubstep");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}