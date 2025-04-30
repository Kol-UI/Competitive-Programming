// Unnatural Language Processing
namespace CompetitiveProgramming.CodeForces.UnnaturalLanguageProcessing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;
            bool[] p = new bool[n + 10];
            
            for (int i = n - 1; i >= 0; i--)
            {
                if (str[i] == 'a' || str[i] == 'e')
                {
                    i--;
                    p[i] = true;
                }
                else
                {
                    i -= 2;
                    p[i] = true;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (i != 0 && p[i])
                {
                    Console.Write('.');
                }
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Unnatural Language Processing");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}