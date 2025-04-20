// Two-gram
namespace CompetitiveProgramming.CodeForces.Twogram;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        string str = Console.ReadLine()!;
        string ans = "";
        int temp = 0;

        for (int i = 0; i < n - 1; i++)
        {
            int cnt = 0;
            for (int j = 0; j < n - 1; j++)
            {
                if (str[i] == str[j] && str[i + 1] == str[j + 1])
                    cnt++;
            }

            if (cnt > temp)
            {
                temp = cnt;
                ans = str.Substring(i, 2);
            }
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Two-gram");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}