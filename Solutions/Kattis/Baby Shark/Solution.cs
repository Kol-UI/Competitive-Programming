// Baby Shark
namespace CompetitiveProgramming.Kattis.BabyShark;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Solution
{
    static void Main()
    {
        string[] ws = Console.ReadLine().Split();

        int i = 0;
        int ansc = 0;
        string anss = "";

        while (i < ws.Length)
        {
            int j = i;
            while (j < ws.Length && ws[j] == ws[i]) j++;

            if (j - i > ansc)
            {
                ansc = j - i;
                anss = ws[i];
            }

            i = j;
        }

        Console.WriteLine(anss);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Baby Shark");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}