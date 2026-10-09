// Little Girl and Game
namespace CompetitiveProgramming.CodeForces.LittleGirlandGame;
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
        string line = Console.ReadLine();

        const int alphaLength = 26;
        int[] array = new int[alphaLength];

        for (int k = 0; k < line.Length; k++)
            array[line[k] - 'a']++;

        int oddLetters = 0;
        for (int k = 0; k < alphaLength; k++)
            if (array[k] % 2 != 0) oddLetters++;

        if (oddLetters == 0 || oddLetters % 2 == 1) Console.WriteLine("First");
        else Console.WriteLine("Second");
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Little Girl and Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}