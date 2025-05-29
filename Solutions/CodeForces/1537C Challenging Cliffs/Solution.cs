// Challenging Cliffs
namespace CompetitiveProgramming.CodeForces.ChallengingCliffs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Array.Sort(v);
            int mn = int.MaxValue;
            int firstpos = 0;
            for (int i = 1; i < n; i++)
            {
                if (v[i] - v[i - 1] < mn)
                {
                    mn = v[i] - v[i - 1];
                    firstpos = i - 1;
                }
            }
            Console.Write(v[firstpos] + " ");
            for (int i = firstpos + 2; i < n; i++)
                Console.Write(v[i] + " ");
            for (int i = 0; i < firstpos; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine(v[firstpos + 1]);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Challenging Cliffs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}