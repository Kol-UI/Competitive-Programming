// Modulo
namespace CompetitiveProgramming.Kattis.Modulo;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        bool[] mod = new bool[42];
        
        for (int i = 0; i < 10; i++)
        {
            int temp = int.Parse(Console.ReadLine());
            mod[temp % 42] = true;
        }
        
        int trues = 0;
        
        for (int i = 0; i < 42; i++)
        {
            if (mod[i])
            {
                trues++;
            }
        }
        
        Console.WriteLine(trues);
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Modulo");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}