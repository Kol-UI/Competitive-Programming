// Timebomb
namespace CompetitiveProgramming.Kattis.Timebomb;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void StrToNums(string s, List<string> nums, int n)
    {
        for (int i = 0; i < n; i++)
        {
            nums[i] += s[i * 4];
            nums[i] += s[i * 4 + 1];
            nums[i] += s[i * 4 + 2];
        }
    }

    static void Main()
    {
        Dictionary<string, int> m = new Dictionary<string, int>
        {
            { "**** ** ** ****", 0 },
            { "  *  *  *  *  *", 1 },
            { "***  *****  ***", 2 },
            { "***  ****  ****", 3 },
            { "* ** ****  *  *", 4 },
            { "****  ***  ****", 5 },
            { "****  **** ****", 6 },
            { "***  *  *  *  *", 7 },
            { "**** ***** ****", 8 },
            { "**** ****  ****", 9 }
        };

        string s = Console.ReadLine();
        int n = s.Length / 4 + 1;
        List<string> nums = new List<string>();
        for (int i = 0; i < n; i++) nums.Add("");

        StrToNums(s, nums, n);

        for (int i = 0; i < 4; i++)
        {
            s = Console.ReadLine();
            StrToNums(s, nums, n);
        }

        int num = 0;
        foreach (string str in nums)
        {
            if (!m.ContainsKey(str))
            {
                Console.WriteLine("BOOM!!");
                return;
            }
            num = num * 10 + m[str];
        }

        if (num % 6 == 0)
            Console.WriteLine("BEER!!");
        else
            Console.WriteLine("BOOM!!");
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
        StyleHelper.Title("Timebomb");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}