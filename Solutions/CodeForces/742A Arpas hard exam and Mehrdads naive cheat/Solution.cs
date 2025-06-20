// Arpa’s hard exam and Mehrdad’s naive cheat
namespace CompetitiveProgramming.CodeForces.ArpashardexamandMehrdadsnaivecheat;

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604
using System;

class Program
{
    static long Solve(int power)
    {
        long result = 1;
        int mod = 10;
        long baseNum = 8;
        while (power > 0)
        {
            if (power % 2 == 1)
                result = (result % mod) * (baseNum % mod) % mod;
            baseNum = (baseNum % mod) * (baseNum % mod) % mod;
            power /= 2;
        }
        return result;
    }

    //static void Main()
    public static void MainSolution()
    {
        int power = int.Parse(Console.ReadLine());
        Console.WriteLine(Solve(power));
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
        StyleHelper.Title("Arpa’s hard exam and Mehrdad’s naive cheat");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
	}
}