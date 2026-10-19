// Anti-Sudoku
namespace CompetitiveProgramming.CodeForces.AntiSudoku;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            for (long p = 0; p < 9; p++)
            {
                string s = Console.ReadLine();
                char[] arr = s.ToCharArray();
                for (long q = 0; q < 9; q++)
                {
                    if (arr[q] == '1') arr[q] = '2';
                }
                Console.WriteLine(new string(arr));
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Anti-Sudoku");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}