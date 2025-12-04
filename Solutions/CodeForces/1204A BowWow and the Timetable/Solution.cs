// BowWow and the Timetable
namespace CompetitiveProgramming.CodeForces.BowWowandtheTimetable;
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
        string s = Console.ReadLine();
        bool isPower = s == "0" || s[0] == '1';
        
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != '0')
            {
                isPower = false;
                break;
            }
        }
        
        bool fullWidth = isPower && s.Length % 2 == 1;
        long count = (s.Length + 1 - (isPower ? 1 : 0)) / 2;
        Console.WriteLine(count);
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
        StyleHelper.Title("BowWow and the Timetable");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}