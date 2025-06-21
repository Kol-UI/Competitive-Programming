// Lecture
namespace CompetitiveProgramming.CodeForces.Lecture;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;

using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] nm = Console.ReadLine().Split();
        int n = int.Parse(nm[0]);
        int m = int.Parse(nm[1]);
        
        Dictionary<string, string> mp = new Dictionary<string, string>();
        
        while (m-- > 0)
        {
            string[] words = Console.ReadLine().Split();
            string sa = words[0];
            string sb = words[1];
            
            mp[sa] = sa.Length <= sb.Length ? sa : sb;
        }
        
        string[] lecture = Console.ReadLine().Split();
        for (int i = 0; i < n; i++)
        {
            Console.Write(mp[lecture[i]] + " ");
        }
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
        StyleHelper.Title("Lecture");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}