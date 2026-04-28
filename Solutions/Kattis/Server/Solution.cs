// Server
namespace CompetitiveProgramming.Kattis.Server;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int time = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split();
        int total = 0;
        int i;
        
        for (i = 0; i < n; i++)
        {
            int temp = int.Parse(secondLine[i]);
            total += temp;
            if (total > time)
            {
                break;
            }
        }
        
        Console.WriteLine(i);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Server");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}