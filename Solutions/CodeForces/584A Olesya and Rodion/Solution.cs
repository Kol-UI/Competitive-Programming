// Olesya and Rodion
namespace CompetitiveProgramming.CodeForces.OlesyaandRodion;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;
using System.Text;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int t = int.Parse(input[1]);

        if (n == 1 && t == 10)
        {
            Console.WriteLine(-1);
            return;
        }

        StringBuilder result = new StringBuilder();
        if (t == 10)
        {
            result.Append('1');
            for (int i = 1; i < n; i++)
                result.Append('0');
        }
        else
        {
            for (int i = 0; i < n; i++)
                result.Append(t.ToString());
        }

        Console.WriteLine(result.ToString());
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
        StyleHelper.Title("Olesya and Rodion");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}