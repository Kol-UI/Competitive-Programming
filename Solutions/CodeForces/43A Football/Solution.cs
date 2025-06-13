// Football
namespace CompetitiveProgramming.CodeForces.Football43A;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        Dictionary<string, int> str = new Dictionary<string, int>();
        int t = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < t; i++)
        {
            string s = Console.ReadLine();
            if (str.ContainsKey(s))
                str[s]++;
            else
                str[s] = 1;
        }
        
        string ans = "";
        int temp = 0;
        
        foreach (var pair in str)
        {
            if (pair.Value > temp)
            {
                temp = pair.Value;
                ans = pair.Key;
            }
        }
        
        Console.WriteLine(ans);
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
        StyleHelper.Title("Football 43A");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}