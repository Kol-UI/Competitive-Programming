// Pokechat
namespace CompetitiveProgramming.Kattis.Pokechat;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string s = Console.ReadLine();
        string enc = Console.ReadLine().Trim();
        
        for (int i = 0; i + 2 < enc.Length; i += 3)
        {
            string numStr = enc.Substring(i, 3);
            int index = int.Parse(numStr) - 1;
            Console.Write(s[index]);
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Pokechat");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}