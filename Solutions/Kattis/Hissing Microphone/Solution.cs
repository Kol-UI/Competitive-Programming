// Hissing Microphone
namespace CompetitiveProgramming.Kattis.HissingMicrophone;
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
        string s = Console.ReadLine();
        
        int i = 0;
        bool f = false;
        
        foreach (char c in s)
        {
            if (c == 's')
            {
                i++;
                if (i == 2)
                {
                    f = true;
                    break;
                }
            }
            else
            {
                i = 0;
            }
        }
        
        if (f)
        {
            Console.WriteLine("hiss");
        }
        else
        {
            Console.WriteLine("no hiss");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hissing Microphone");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}