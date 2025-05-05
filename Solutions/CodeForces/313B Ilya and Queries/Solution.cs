// Ilya and Queries
namespace CompetitiveProgramming.CodeForces.IlyaandQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string str = Console.ReadLine()!;
        long[] psum = new long[str.Length + 1];
        for (int i = 1; i < str.Length; i++)
        {
            psum[i + 1] = psum[i] + (str[i] == str[i - 1] ? 1 : 0);
        }

        int q = int.Parse(Console.ReadLine()!);
        while (q-- > 0)
        {
            string[] lr = Console.ReadLine()!.Split();
            int l = int.Parse(lr[0]);
            int r = int.Parse(lr[1]);
            Console.WriteLine(psum[r] - psum[l]);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ilya and Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}