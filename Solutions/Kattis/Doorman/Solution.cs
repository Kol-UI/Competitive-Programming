// Doorman
namespace CompetitiveProgramming.Kattis.Doorman;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int d = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int n = s.Length;
        
        int dl = 0;
        int ans = 0;
        int i = 0;
        
        while (i < n)
        {
            if (i < n - 1 && s[i] != s[i + 1])
            {
                ans += 2;
                i += 2;
                continue;
            }
            if (s[i] == 'W' && dl < d)
            {
                ans += 1;
                dl += 1;
                i += 1;
                continue;
            }
            if (s[i] == 'M' && dl > -d)
            {
                ans += 1;
                dl -= 1;
                i += 1;
                continue;
            }
            break;
        }
        
        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Doorman");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}