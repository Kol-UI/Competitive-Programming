// Vaccine Dates


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeChef.VaccineDates;

public class Test
{
	//public static void Main()
    public static void Solution()
	{
		int T = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < T; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            int D = int.Parse(input[0]);
            int L = int.Parse(input[1]);
            int R = int.Parse(input[2]);
            
            string result = CheckVaccine(D, L, R);
            Console.WriteLine(result);
        }
	}
	
	public static string CheckVaccine(int D, int L, int R)
	{
        if (D < L)
        {
            return "Too Early";
        }
        else if (D > R)
        {
            return "Too Late";
        }
        else
        {
            return "Take second dose now";
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Vaccine Dates");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeChef, ProblemCategory.BeginnerCC);
        }
    }
}
