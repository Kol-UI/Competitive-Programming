// Battle Simulation
namespace CompetitiveProgramming.Kattis.BattleSimulation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static bool Check(string s, int i)
    {
        if (i + 2 >= s.Length) return false;
        int v = s[i] ^ s[i + 1] ^ s[i + 2];
        return v == ('R' ^ 'B' ^ 'L');
    }

    static void Main()
    {
        string s = Console.ReadLine();
        int n = s.Length;

        for (int i = 0; i < n;)
        {
            if (Check(s, i))
            {
                Console.Write('C');
                i += 3;
            }
            else
            {
                if (s[i] == 'R') Console.Write('S');
                if (s[i] == 'B') Console.Write('K');
                if (s[i] == 'L') Console.Write('H');
                i++;
            }
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
        StyleHelper.Title("Battle Simulation");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}