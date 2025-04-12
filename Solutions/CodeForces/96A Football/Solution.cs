// Football
namespace CompetitiveProgramming.CodeForces.AFootball;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string plyrs = Console.ReadLine()!;
        string result = "NO";
        int cnt = 0, cnt1 = 0;

        for(int i = 0; i < plyrs.Length; i++)
        {
            if(plyrs[i] == '1')
            {
                cnt1 = 0;
                cnt++;
                if(cnt == 7)
                {
                    result = "YES";
                    break;
                }
            }
            else if(plyrs[i] == '0')
            {
                cnt = 0;
                cnt1++;
                if(cnt1 == 7)
                {
                    result = "YES";
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Football");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}