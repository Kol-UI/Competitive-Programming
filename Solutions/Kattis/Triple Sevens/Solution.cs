// Triple Sevens
namespace CompetitiveProgramming.Kattis.TripleSevens;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        Console.ReadLine();
        bool fl = false;
        
        for (int i = 0; i < 3; i++)
        {
            if (!Console.ReadLine().Contains("7"))
            {
                fl = true;
            }
        }
        
        Console.WriteLine(fl ? 0 : 777);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Triple Sevens");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}