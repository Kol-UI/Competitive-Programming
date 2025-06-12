// Raising Bacteria
namespace CompetitiveProgramming.CodeForces.RaisingBacteria;
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
        int bacteria = int.Parse(Console.ReadLine());
        int cnt = 0;
        
        while(bacteria != 0)
        {
            if(bacteria % 2 == 1)
            {
                cnt++;
                bacteria--;
            }
            else
            {
                bacteria /= 2;
            }
        }
        
        Console.WriteLine(cnt);
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
        StyleHelper.Title("Raising Bacteria");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}