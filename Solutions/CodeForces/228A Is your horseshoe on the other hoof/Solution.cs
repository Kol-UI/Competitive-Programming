// Is your horseshoe on the other hoof

using System;
using System.Collections.Generic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.Isyourhorseshoeontheotherhoof;

class Program
{
    //static void Main()
    static void Solution()
    {
        string[] input = Console.ReadLine()!.Split();
        int[] colors = Array.ConvertAll(input, int.Parse);

        HashSet<int> distinctColorSet = new HashSet<int>();
        int replacements = 0;

        foreach (int color in colors)
        {
            if (!distinctColorSet.Add(color))
            {
                replacements++;
            }
        }

        Console.WriteLine(replacements);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Is your horseshoe on the other hoof");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}