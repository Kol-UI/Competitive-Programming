// Trik
namespace CompetitiveProgramming.Kattis.Trik;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        bool[] ball = new bool[] { true, false, false };
        string moves = Console.ReadLine();
        
        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'A')
            {
                bool temp = ball[0];
                ball[0] = ball[1];
                ball[1] = temp;
            }
            if (moves[i] == 'B')
            {
                bool temp = ball[1];
                ball[1] = ball[2];
                ball[2] = temp;
            }
            if (moves[i] == 'C')
            {
                bool temp = ball[0];
                ball[0] = ball[2];
                ball[2] = temp;
            }
        }
        
        if (ball[0]) Console.WriteLine("1");
        if (ball[1]) Console.WriteLine("2");
        if (ball[2]) Console.WriteLine("3");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Trik");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}