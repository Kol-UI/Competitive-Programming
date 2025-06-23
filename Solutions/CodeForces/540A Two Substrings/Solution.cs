// Two Substrings
namespace CompetitiveProgramming.CodeForces.TwoSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string x = Console.ReadLine();
        string str = x;
        int cnt = 0;

        int checkAB = str.IndexOf("AB");
        if (checkAB != -1)
        {
            str = str.Remove(checkAB, 2).Insert(checkAB, "##");
            cnt++;
        }

        if (str.IndexOf("BA") != -1)
            cnt++;

        if (cnt < 2)
        {
            str = x;
            int checkBA = str.IndexOf("BA");
            cnt = 0;

            if (checkBA != -1)
            {
                str = str.Remove(checkBA, 2).Insert(checkBA, "##");
                cnt++;
            }

            if (str.IndexOf("AB") != -1)
                cnt++;
        }

        Console.WriteLine(cnt > 1 ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Two Substrings");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1500);
	}
}