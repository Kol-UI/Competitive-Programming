// Soft Passwords
namespace CompetitiveProgramming.Kattis.SoftPasswords;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;

class Program
{
    static bool Possibilities(string p, string target)
    {
        if (p == target) return true;

        for (int i = 0; i < 10; i++)
        {
            if (i.ToString() + p == target) return true;
            if (p + i.ToString() == target) return true;
        }

        char[] revcArr = new char[p.Length];
        for (int i = 0; i < p.Length; i++)
        {
            char c = p[i];
            if (c >= 'a' && c <= 'z')
                revcArr[i] = char.ToUpper(c);
            else if (c >= 'A' && c <= 'Z')
                revcArr[i] = char.ToLower(c);
            else
                revcArr[i] = c;
        }
        string revc = new string(revcArr);

        if (revc == target) return true;

        return false;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        string p = Console.ReadLine();

        Console.WriteLine(Possibilities(p, s) ? "Yes" : "No");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Soft Passwords");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}