// Sibice
namespace CompetitiveProgramming.Kattis.Sibice;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604


using System;
using System.Linq;

class Solution
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int w = int.Parse(firstLine[1]);
        int h = int.Parse(firstLine[2]);
        
        double maxLength = Math.Sqrt(w * w + h * h);
        
        for (int i = 0; i < n; i++)
        {
            int matchLength = int.Parse(Console.ReadLine());
            Console.WriteLine(matchLength <= maxLength ? "DA" : "NE");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sibice");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}