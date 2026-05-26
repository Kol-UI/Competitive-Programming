// Beekeeper
namespace CompetitiveProgramming.Kattis.Beekeeper;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;

class Program
{
    static bool IsVowel(char c)
    {
        switch (c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'y':
                return true;
            default:
                return false;
        }
    }

    static int Count(string s)
    {
        int doubles = 0;
        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] == s[i + 1] && IsVowel(s[i]))
            {
                doubles++;
            }
        }
        return doubles;
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            if (n == 0) break;

            string favorite = "none";
            int doubles = -1;

            for (int i = 0; i < n; i++)
            {
                string temp = Console.ReadLine();
                int d = Count(temp);
                if (d > doubles)
                {
                    doubles = d;
                    favorite = temp;
                }
            }

            Console.WriteLine(favorite);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Beekeeper");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}