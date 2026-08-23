// Multigram
namespace CompetitiveProgramming.Kattis.Multigram;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static bool Check(string s, string c)
    {
        char[] cArr = c.ToCharArray();
        Array.Sort(cArr);
        string sortedC = new string(cArr);

        int n = s.Length;
        int len = c.Length;

        for (int i = 0; i < n; i += len)
        {
            string sub = s.Substring(i, len);
            char[] subArr = sub.ToCharArray();
            Array.Sort(subArr);
            string sortedSub = new string(subArr);

            if (sortedSub != sortedC)
                return false;
        }

        return true;
    }

    static void Main()
    {
        string s = Console.ReadLine();
        int n = s.Length;

        for (int i = 1; i < n; i++)
        {
            if (n % i == 0 && Check(s, s.Substring(0, i)))
            {
                Console.WriteLine(s.Substring(0, i));
                return;
            }
        }

        Console.WriteLine(-1);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Multigram");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}