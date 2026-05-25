// Eligibility
namespace CompetitiveProgramming.Kattis.Eligibility;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] parts = Console.ReadLine().Split();
            string name = parts[0];
            string school = parts[1];
            string age = parts[2];
            int courses = int.Parse(parts[3]);

            Console.Write($"{name} ");

            int schoolYear = int.Parse(school.Split('/')[0]);
            if (schoolYear >= 2010)
            {
                Console.WriteLine("eligible");
                continue;
            }

            int ageYear = int.Parse(age.Split('/')[0]);
            if (ageYear >= 1991)
            {
                Console.WriteLine("eligible");
                continue;
            }

            if (courses > 40)
            {
                Console.WriteLine("ineligible");
                continue;
            }

            Console.WriteLine("coach petitions");
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
        StyleHelper.Title("Eligibility");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}