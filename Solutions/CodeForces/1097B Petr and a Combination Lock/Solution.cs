// Petr and a Combination Lock
namespace CompetitiveProgramming.CodeForces.PetrandaCombinationLock;
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
        int[] angles = new int[n];
        for (int i = 0; i < n; i++)
            angles[i] = int.Parse(Console.ReadLine()!);

        bool possible = false;
        for (int mask = 0; mask < (1 << n); mask++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
                sum += (mask & (1 << i)) != 0 ? angles[i] : -angles[i];
            
            if (sum % 360 == 0)
            {
                possible = true;
                break;
            }
        }

        Console.WriteLine(possible ? "YES" : "NO");
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Petr and a Combination Lock");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}